using d01ApiV2.DbFactory.Interface;
using d01ApiV2.Repository.Interface.Profile;

namespace d01ApiV2.Repository.Implementation.Profile
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IAppDbFactory _appDbFactory;

        public BrandRepository(IAppDbFactory appDbFactory)
        {
            _appDbFactory = appDbFactory;
        }
    }
}
