using Database.Models;

namespace Database.Repositories
{
    public class OrganizationRepo : BaseRepo<idaxOrganization, IDAX_ORGANIZATION>, IOrganizationRepo
    {
        public OrganizationRepo(MyDbContext ApplicationDatabaseContext) : base(ApplicationDatabaseContext)
        {

        }
    }
}
