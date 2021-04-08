using Database.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Export.UnitTest
{
    [TestFixture]
    public class TestTemplateDepartment : TestGeneric
    {
        long _CountOfDbo;
        long _CountOfIdx;
        public override long CountOfDbo { get => _CountOfDbo; set => value = _CountOfDbo; }
        public override long CountOfIdx { get => _CountOfIdx; set => value = _CountOfIdx; }

        IEnumerable<idaxTemplateDepartment> dbo;
        IEnumerable<IDAX_TEMPLATE_DEPARTMENT> idx;

        [SetUp]
        public new void SetUp()
        {
            var scenarioId = RegisterService.latest_ScenarioId;
            dbo = RegisterService.templateDepartmentRepo.GetAll_dbo().Where(w => scenarioId.Equals(w.ScenarioId.ToString())).ToList();
            idx = RegisterService.templateDepartmentRepo.GetAll_idaxExport().Where(w => scenarioId.Equals(w.ScenarioId)).ToList();

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
                        var _dbo = dbo.Where(w => 
                                        _idx.Department.Equals(w.Department)
                                        && (string.IsNullOrEmpty(_idx.Prefix) || _idx.Prefix.Equals(w.Prefix))
                                        && _idx.Asset.Equals(w.Asset)
                                        && (string.IsNullOrEmpty(_idx.Suffix) || _idx.Suffix.Equals(w.Suffix))
                                        && _idx.Source.Equals(w.Source)
                                        && _idx.UpdateGuid.Equals(w.UpdateGuid.ToString())
                                    ).FirstOrDefault();

                        string keys = $"\nDepartment={_idx.Department}\nAsset={_idx.Asset}\nSource={_idx.Source}\nPrefix={_idx.Prefix}\nSuffix={_idx.Suffix}";
                        if (_dbo != null)
                        {
                            decimal _Score;
                            decimal.TryParse(_idx.Score, out _Score);
                            Assert.AreEqual(Math.Round(_Score,3,MidpointRounding.AwayFromZero), Math.Round((_dbo.Score ?? 0), 3, MidpointRounding.AwayFromZero), $"keys: {keys} at field: Score");
                        }
                        else
                        {
                            Assert.Fail($"dbo schema does not eixst data for keys={keys}");
                        }
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

