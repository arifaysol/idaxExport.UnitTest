using Database.Models;

namespace Database.Repositories
{
    public class DuplicateAssetsRepo : BaseRepo<idaxDuplicateAssets, IDAX_DUPLICATE_ASSETS>, IDuplicateAssetsRepo
    {
        public DuplicateAssetsRepo(MyDbContext ApplicationDatabaseContext) : base(ApplicationDatabaseContext)
        {

        }
    }
}
