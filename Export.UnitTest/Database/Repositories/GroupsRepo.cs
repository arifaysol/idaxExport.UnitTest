using Database.Models;

namespace Database.Repositories
{
    public class GroupsRepo : BaseRepo<idaxGroups, IDAX_GROUPS>, IGroupsRepo
    {
        public GroupsRepo(MyDbContext ApplicationDatabaseContext) : base(ApplicationDatabaseContext)
        {

        }
    }
}
