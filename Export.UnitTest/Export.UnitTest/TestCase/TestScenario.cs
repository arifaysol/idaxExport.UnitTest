using Database.Models;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace Export.UnitTest
{
    [TestFixture]
    public class TestScenario: TestGeneric
    {
        long _CountOfDbo;
        long _CountOfIdx;
        public override long CountOfDbo { get => _CountOfDbo; set => value = _CountOfDbo; }
        public override long CountOfIdx { get => _CountOfIdx; set => value = _CountOfIdx; }

        idaxScenarios dbo;
        IDAX_SCENARIOS idx;

        [SetUp]
        public new void SetUp()
        {
            var scenarioId = RegisterService.latest_ScenarioId;
            dbo = RegisterService.scenarioRepo.GetAll_dbo().Where(w => scenarioId.Equals(w.ScenarioId.ToString())).FirstOrDefault();
            idx = RegisterService.scenarioRepo.GetAll_idaxExport().Where(w => scenarioId.Equals(w.ScenarioId)).FirstOrDefault();

            _CountOfDbo = dbo != null ? 1 : 0;
            _CountOfIdx = idx != null ? 1 : 0;
        }

        [TestCase]
        public override async Task CompareLineBaseLineLatestRows()
        {
            await Task.Run(() =>
            {
                if (dbo != null && idx != null)
                {

                    Assert.AreEqual(idx.ScenarioId, dbo.ScenarioId.ToString());
                    Assert.AreEqual(idx.UpdateDate, dbo.UpdateDate);
                    Assert.AreEqual(idx.UpdateGuid, dbo.UpdateGuid.ToString());
                    Assert.AreEqual(idx.ScenarioName, dbo.ScenarioName);
                    Assert.AreEqual(idx.ExportType, dbo.ExportType);
                }
                else
                {
                    Assert.Fail("dbo OR idaxExport schema is NULL");
                }
            }); 
            
        }
    }
}
