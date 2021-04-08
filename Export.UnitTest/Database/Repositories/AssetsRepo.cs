using Database.Models;

namespace Database.Repositories
{
    public class AssetsRepo : BaseRepo<idaxAssets, IDAX_ASSETS>, IAssetsRepo
    {
        //public MyDbContext ApplicationDatabaseContext
        //{
        //    get { return MyDbContext as ApplicationDatabaseContext; }
        //}
        public AssetsRepo(MyDbContext ApplicationDatabaseContext) : base(ApplicationDatabaseContext)
        {

        }
    }
}
