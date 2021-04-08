using Database.Models;

namespace Database.Repositories
{
    public class ScenarioRepo: BaseRepo<idaxScenarios, IDAX_SCENARIOS>, IScenarioRepo
    {
        public ScenarioRepo(MyDbContext ApplicationDatabaseContext) : base(ApplicationDatabaseContext)
        {

        }
    }
}
