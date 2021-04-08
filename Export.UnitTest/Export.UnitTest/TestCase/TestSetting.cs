using Database.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Export.UnitTest
{
    [TestFixture]
    public class TestSetting : TestGeneric
    {
        long _CountOfDbo;
        long _CountOfIdx;
        public override long CountOfDbo { get => _CountOfDbo; set => value = _CountOfDbo; }
        public override long CountOfIdx { get => _CountOfIdx; set => value = _CountOfIdx; }

        IEnumerable<idaxSettings> dbo;
        IEnumerable<IDAX_SETTINGS> idx;

        [SetUp]
        public new void SetUp()
        {
            var scenarioId = RegisterService.latest_ScenarioId;
            dbo = RegisterService.settingRepo.GetAll_dbo().Where(w => scenarioId.Equals(w.ScenarioId.ToString())).ToList();
            idx = RegisterService.settingRepo.GetAll_idaxExport().Where(w => scenarioId.Equals(w.ScenarioId)).ToList();

            _CountOfDbo = dbo.Count();
            _CountOfIdx = idx.Count();
        }

        [TestCase]
        public override async Task CompareLineBaseLineLatestRows()
        {
            await Task.Run(() =>
            {
                if (dbo != null && idx != null)
                {

                    foreach (var _idx in idx)
                    {
                        var _dbo = dbo.Where(w => _idx.SettingName.Equals(w.SettingName)).FirstOrDefault();
                        Assert.AreEqual(_idx.SettingName, _dbo.SettingName);
                        Assert.AreEqual(_idx.SettingValue, _dbo.SettingValue);
                    }
                }
                else
                {
                    Assert.Fail("dbo OR idaxExport schema is NULL");
                }
            });
        }
    }
}

