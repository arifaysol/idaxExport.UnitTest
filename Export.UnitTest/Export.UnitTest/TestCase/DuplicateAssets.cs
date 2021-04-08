using Database.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Export.UnitTest
{
    [TestFixture]
    public class DuplicateAssets : TestGeneric
    {
        long _CountOfDbo;
        long _CountOfIdx;
        public override long CountOfDbo { get => _CountOfDbo; set => value = _CountOfDbo; }
        public override long CountOfIdx { get => _CountOfIdx; set => value = _CountOfIdx; }

        IEnumerable<idaxDuplicateAssets> dbo;
        IEnumerable<IDAX_DUPLICATE_ASSETS> idx;

        [SetUp]
        public new void SetUp()
        {
            var scenarioId = RegisterService.latest_ScenarioId;
            dbo = RegisterService.duplicateAssetsRepo.GetAll_dbo().Where(w => scenarioId.Equals(w.ScenarioId.ToString())).ToList();
            idx = RegisterService.duplicateAssetsRepo.GetAll_idaxExport().Where(w => scenarioId.Equals(w.ScenarioId)).ToList();

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
                        string keys = $"\nDupId={_idx.DupId}\nDupName={_idx.DupName}\nAsset={_idx.Asset}\nSource={_idx.Source}\nPrefix={_idx.Prefix}\nSuffix={_idx.Suffix}";
                        var _dbo = dbo.Where(w => 
                                            _idx.DupId.Equals(w.DupId.ToString())
                                            && _idx.DupName.Equals(w.DupName)
                                            && _idx.Asset.Equals(w.Asset)
                                            && _idx.Source.Equals(w.Source)
                                            && (string.IsNullOrEmpty(_idx.Prefix) || _idx.Prefix.Equals(w.Prefix))
                                            && (string.IsNullOrEmpty(_idx.Suffix) || _idx.Suffix.Equals(w.Suffix))
                                            && _idx.UpdateGuid.Equals(w.UpdateGuid.ToString())
                                    ).FirstOrDefault();
                        Assert.IsNotNull(_dbo, $"dbo schema does not eixst data for keys: {keys}");
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

