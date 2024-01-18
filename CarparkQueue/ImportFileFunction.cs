using Carpark.BL.Services.Interfaces;
using Carpark.Data.CarparkDbContext;
using Microsoft.Azure.Storage.Blob;
using Microsoft.Azure.WebJobs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace CarparkQueue
{
    public class ImportFileFunction
    {
        private readonly IImportFileBiz _importFileBiz;
        private readonly CarparkDbContext _context;

        public ImportFileFunction(IImportFileBiz importFileBiz, CarparkDbContext context)
        {
            _importFileBiz = importFileBiz;
            _context = context;
        }

        [FunctionName("ImportFileFunction")]
        public void Run([BlobTrigger("carpark-queue/{name}", Connection = "Carpark")]Stream myBlob, string name, ILogger log)
        {
            var connectionString = Environment.GetEnvironmentVariable("AzureWebJobsStorage", EnvironmentVariableTarget.Process);

            if (string.IsNullOrEmpty(connectionString))
            {
                log.LogError("CarparkDb connection string is not set.");
                return;
            }

            var cloudStorageAccount = Microsoft.Azure.Storage.CloudStorageAccount.Parse(connectionString);

            var datetimePrefix = DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "_";
            var sourceContainer = "carpark-queue";
            var destinationContainer = "carpark-queue";
            var sourceFilename = name;
            var destinationFilename = "Backup/" + datetimePrefix + name;

            var ext = Path.GetExtension(name);

            var dataTable = _importFileBiz.GenerateDataTable(name, myBlob);

            var columnMappings = new Dictionary<string, string>
            {
                { "CarParkNo", "car_park_no" },
                { "Address", "address" },
                { "XCoord", "x_coord" },
                { "YCoord", "y_coord" },
                { "CarParkType", "car_park_type" },
                { "ParkingTypeSystem", "type_of_parking_system" },
                { "ShortTermParkingType", "short_term_parking" },
                { "FreeParkingType", "free_parking" },
                { "NightParkingType", "night_parking" },
                { "CarParkDeck", "car_park_decks" },
                { "GantryHeight", "gantry_height" },
                { "CarParkBasement", "car_park_basement" }
            };

            var dbSet = _context.Set<Carpark.Data.Entities.CarPark>();

            var entities = dataTable.AsEnumerable().Select(row => new Carpark.Data.Entities.CarPark
            {
                CarParkNo = row.Field<string>("car_park_no"),
                Address = row.Field<string>("address"),
                XCoord = decimal.TryParse(row.Field<string>("x_coord"), out var xCoordValue) ? xCoordValue : default,
                YCoord = decimal.TryParse(row.Field<string>("y_coord"), out var yCoordValue) ? yCoordValue : default,
                CarParkType = short.TryParse(row.Field<string>("car_park_type"), out var carparkType) ? carparkType : default,
                ParkingTypeSystem = short.TryParse(row.Field<string>("type_of_parking_system"), out var parkingSystem) ? parkingSystem : default,
                ShortTermParkingType = short.TryParse(row.Field<string>("short_term_parking"), out var shortTermParking) ? shortTermParking : default,
                FreeParkingType = short.TryParse(row.Field<string>("free_parking"), out var freeParking) ? freeParking : default,
                NightParkingType = short.TryParse(row.Field<string>("night_parking"), out var nightParking) ? nightParking : default,
                CarParkDeck = short.TryParse(row.Field<string>("car_park_decks"), out var carparkDeck) ? carparkDeck : default,
                GantryHeight = decimal.TryParse(row.Field<string>("gantry_height"), out var gannyHeight) ? gannyHeight : default,
                CarParkBasement = short.TryParse(row.Field<string>("car_park_basement"), out var carparkBasement) ? carparkBasement : default
            }).ToList();

            using (var connection = new SqlConnection(_context.Database.GetDbConnection().ConnectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {

                    try
                    {
                        var bulkInsertTable = new DataTable();
                        foreach (var property in typeof(Carpark.Data.Entities.CarPark).GetProperties())
                        {
                            if (property.PropertyType.Namespace != "System" 
                                && !property.PropertyType.IsValueType 
                                && property.PropertyType != typeof(string))
                            {
                                continue;
                            }

                            if (columnMappings.TryGetValue(property.Name, out var columnName))
                            {
                                bulkInsertTable.Columns.Add(columnName, Nullable.GetUnderlyingType(property.PropertyType) 
                                    ?? property.PropertyType);
                            }
                        }
                        bulkInsertTable.PrimaryKey = new DataColumn[] { bulkInsertTable.Columns["car_park_no"] };

                        foreach (var entity in entities)
                        {
                            var newRow = bulkInsertTable.NewRow();
                            foreach (var property in typeof(Carpark.Data.Entities.CarPark).GetProperties())
                            {
                                if (columnMappings.TryGetValue(property.Name, out var columnName))
                                {
                                    newRow[columnName] = property.GetValue(entity) ?? DBNull.Value;
                                }
                            }
                            bulkInsertTable.Rows.Add(newRow);
                        }

                        using (var bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction))
                        {
                            bulkCopy.DestinationTableName = "car_park";
                            
                            foreach (DataColumn column in bulkInsertTable.Columns)
                                bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);

                             bulkCopy.WriteToServer(bulkInsertTable);
                        }

                        transaction.Commit();

                        var copyResult = CopyBlob(cloudStorageAccount, sourceContainer, destinationContainer, name, destinationFilename);

                        if (copyResult.Status == CopyStatus.Success)
                        {
                            DeleteBlob(cloudStorageAccount, sourceContainer, sourceFilename);
                        }
                    }
                    catch (Exception ex)
                    {
                        log.LogError($"Error during bulk insert: {ex.Message}");
                        transaction.Rollback();
                    }
                }
            }
        }

        private static CopyState CopyBlob(Microsoft.Azure.Storage.CloudStorageAccount cloudStorageAccount, string sourceContainerName, string destinationContainerName, string sourceFileName, string destinationFileName)
        {
            var blobStorageClient = cloudStorageAccount.CreateCloudBlobClient();

            var sourceContainer = blobStorageClient.GetContainerReference(sourceContainerName);
            var destinationContainer = blobStorageClient.GetContainerReference(destinationContainerName);

            var sourceBlob = sourceContainer.GetBlobReference(sourceFileName);

            var destinationBlob = destinationContainer.GetBlobReference(destinationFileName);

            var result = destinationBlob.StartCopy(sourceBlob.Uri);

            var copyResult = destinationBlob.CopyState;

            return copyResult;
        }

        private static void DeleteBlob(Microsoft.Azure.Storage.CloudStorageAccount cloudStorageAccount, string containerName, string blobFileName)
        {
            var blobStorageClient = cloudStorageAccount.CreateCloudBlobClient();
            var container = blobStorageClient.GetContainerReference(containerName);
            var blob = container.GetBlobReference(blobFileName);
            blob.Delete();
        }
    }
}
