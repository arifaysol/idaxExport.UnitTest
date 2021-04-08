using Database.Models;

namespace Database.Repositories
{
    public class TemplateRoleRepo : BaseRepo<idaxTemplateRole, IDAX_TEMPLATE_ROLE>, ITemplateRoleRepo
    {
        public TemplateRoleRepo(MyDbContext ApplicationDatabaseContext) : base(ApplicationDatabaseContext)
        {

        }
    }
}
