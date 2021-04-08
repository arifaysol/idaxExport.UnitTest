using Database.Models;

namespace Database.Repositories
{
    public class SettingRepo : BaseRepo<idaxSettings, IDAX_SETTINGS>, ISettingRepo
    {
        public SettingRepo(MyDbContext ApplicationDatabaseContext) : base(ApplicationDatabaseContext)
        {

        }
    }
}
