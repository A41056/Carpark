using Carpark.Data.Entities;
using Carpark.Utilities.Enums;
using CsvHelper;
using System.Globalization;

namespace Carpark.Data.Service
{
    public class CsvSeeder
    {
        private readonly CarparkDbContext.CarparkDbContext _context;
        private readonly string _filePath;

        public CsvSeeder(CarparkDbContext.CarparkDbContext context, string filePath)
        {
            _context = context;
            _filePath = filePath;
        }

        public void Seed()
        {
            //using (var reader = new StreamReader(_filePath))
            //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    var records = csv.GetRecords<CarparkRecordModel>().ToList();

            //    foreach (var record in records)
            //    {
            //        var carpark = new CarPark
            //        {
            //            CarParkNo = record.CarParkNo,
            //            Address = record.Address,
            //            XCoord = record.XCoord,
            //            YCoord = record.YCoord,
            //            CarParkType = (short)GetCarParkType(record.CarParkType),
            //            TypeOfParkingSystem = (short)GetTypeOfParking(record.TypeOfParkingSystem),
            //            CarParkDeck = GetCarParkDeck(record.CarParkDeck),
            //            FreeParking = (short)GetFreeParkingEnum(record.FreeParking),
            //            NightParking = GetNightParking(record.NightParking),
            //            ShortTermParking = (short)GetShortTermParking(record.ShortTermParking),
            //            GantryHeight = record.GannyHeight,
            //            CarParkBasement = GetCarParkBasement(record.CarParkBasement)
            //        };

            //        _context.Carparks.Add(carpark);
            //    }

            //    _context.SaveChanges();
            //}
        }

        private ECarParkType GetCarParkType(string carparkType)
        {
            ECarParkType carParkType = ECarParkType.Unknow;

            switch (carparkType)
            {
                case "BASEMENT CAR PARK":
                    carParkType = ECarParkType.BasementCarPark;
                    break;
                case "MULTI-STOREY CAR PARK":
                    carParkType = ECarParkType.MultiStoreyCarPark;
                    break;
                case "SURFACE CAR PARK":
                    carParkType = ECarParkType.SurfaceCarPark;
                    break;
                default:
                    carParkType = ECarParkType.Unknow;
                    break;
            }

            return carParkType;
        }

        private ETypeOfParking GetTypeOfParking(string typeOfParking)
        {
            ETypeOfParking parkingType = ETypeOfParking.Unknow;

            switch (typeOfParking)
            {
                case "ELECTRONIC PARKING":
                    parkingType = ETypeOfParking.ElectronicParking;
                    break;
                case "COUPON PARKING":
                    parkingType = ETypeOfParking.CouponParking;
                    break;
                default:
                    parkingType = ETypeOfParking.Unknow;
                    break;
            }

            return parkingType;
        }

        private EFreeParking GetFreeParkingEnum(string freeParking)
        {
            EFreeParking parkingFree = EFreeParking.Unknow;

            switch (freeParking)
            {
                case "NO":
                    parkingFree = EFreeParking.No;
                    break;
                case "SUN & PH FR 7AM-10.30PM":
                    parkingFree = EFreeParking.SunPhFr7AmTo1030Pm;
                    break;
                default:
                    parkingFree = EFreeParking.Unknow;
                    break;
            }

            return parkingFree;
        }

        private EShortTermParking GetShortTermParking(string shortTermParking)
        {
            EShortTermParking parkingFree = EShortTermParking.Unknow;

            switch (shortTermParking)
            {
                case "NO":
                    parkingFree = EShortTermParking.No;
                    break;
                case "7AM-7PM":
                    parkingFree = EShortTermParking.AM7to7PM;
                    break;
                case "7AM-10.30PM":
                    parkingFree = EShortTermParking.AM7to1030PM;
                    break;
                case "WHOLE DAY":
                    parkingFree = EShortTermParking.WholeDay;
                    break;
                default:
                    parkingFree = EShortTermParking.Unknow;
                    break;
            }

            return parkingFree;
        }

        private short GetCarParkDeck(string canParkDeck)
        {
            if (string.Compare(canParkDeck, "YES", false) == 0)
                return 1;
            else if (string.Compare(canParkDeck, "NO", false) == 0)
                return 0;

            return -1;
        }

        private short GetCarParkBasement(string nightParking)
        {
            if (string.Compare(nightParking, "YES", false) == 0)
                return 1;
            else if (string.Compare(nightParking, "NO", false) == 0)
                return 0;

            return -1;
        }

        private short GetNightParking(string carparkBasement)
        {
            if (string.Compare(carparkBasement, "YES", false) == 0)
                return 1;
            else if (string.Compare(carparkBasement, "NO", false) == 0)
                return 0;

            return -1;
        }
    }
}


