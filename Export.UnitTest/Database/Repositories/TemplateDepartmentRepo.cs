using Database.Models;

namespace Database.Repositories
{
    public class TemplateDepartmentRepo : BaseRepo<idaxTemplateDepartment, IDAX_TEMPLATE_DEPARTMENT>, ITemplateDepartmentRepo
    {
        public TemplateDepartmentRepo(MyDbContext ApplicationDatabaseContext) : base(ApplicationDatabaseContext)
        {

        }
    }
}
