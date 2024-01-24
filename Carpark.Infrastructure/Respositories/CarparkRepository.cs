using Carpark.Core;
using Carpark.Core.Common;
using Carpark.Core.Entities;
using Carpark.Core.Interfaces;
using Carpark.Core.Models;
using Carpark.Infrastructure.Db;
using System.Linq.Expressions;

namespace Carpark.Infrastructure.Respositories
{
    public class CarparkRepository : BaseRepository<CarPark>, ICarparkRepository
    {
        public CarparkRepository(CarparkDbContext dbContext) : base(dbContext) 
        {

        }

        public async Task<PaginatedResponseModel<CarPark>> GetListCarpark(SearchingCarparkInfoRequest request)
        {

            return await GetPaginatedDataByRequest(
                request,
                filter: f =>
                    (request.CarParkType == null || f.CarParkType == (short)request.CarParkType) &&
                    (request.FreeParkingType == null || f.FreeParkingType == (short)request.FreeParkingType) &&
                    (request.NightParkingType == null || f.NightParkingType == (short)request.NightParkingType) &&
                    (request.ParkingTypeSystem == null || f.ParkingTypeSystem == (short)request.ParkingTypeSystem) &&
                    (request.ShortTermParkingType == null || f.ShortTermParkingType == (short)request.ShortTermParkingType) &&
                    (request.GantryHeight == null || f.GantryHeight == (decimal)request.GantryHeight)
                    ,
                includes: new Expression<Func<CarPark, object>>[]
                {
                    i => i.CarParkTypeNavigation,
                    i => i.FreeParkingNavigation,
                    i => i.NightParkingNavigation
                },
                orderBy: o => o.OrderBy(x => x.CreatedAt)
            );
        }
    }
}
