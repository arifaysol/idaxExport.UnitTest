using Database.Models;

namespace Database.Repositories
{
    public class EntitlementRepo : BaseRepo<idaxEntitlements, IDAX_ENTITLEMENTS>, IEntitlementsRepo
    {
        public EntitlementRepo(MyDbContext ApplicationDatabaseContext) : base(ApplicationDatabaseContext)
        {

        }
    }
}
