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

            return await GetPaginatedDataByRequest(request, includes: new Expression<Func<CarPark, object>>[]
            {
                i => i.CarParkTypeNavigation,
                i => i.FreeParkingNavigation,
                i => i.NightParkingNavigation
            }, orderBy: o => o.OrderByDescending(x => x.CreatedAt));
        }
    }
}
