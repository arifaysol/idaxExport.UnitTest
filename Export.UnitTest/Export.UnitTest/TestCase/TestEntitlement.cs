using Database.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Export.UnitTest
{
    [TestFixture]
    public class TestEntitlement : TestGeneric
    {
        long _CountOfDbo;
        long _CountOfIdx;
        public override long CountOfDbo { get => _CountOfDbo; set => value = _CountOfDbo; }
        public override long CountOfIdx { get => _CountOfIdx; set => value = _CountOfIdx; }

        IEnumerable<idaxEntitlements> dbo;
        IEnumerable<IDAX_ENTITLEMENTS> idx;

        [SetUp]
        public new void SetUp()
        {
            var scenarioId = RegisterService.latest_ScenarioId;
            _CountOfDbo = RegisterService.entitlementRepo.GetAll_dbo().Count();
            _CountOfIdx = RegisterService.entitlementRepo.GetAll_idaxExport().Count();

            dbo = RegisterService.entitlementRepo.GetAll_dbo().Where(w => scenarioId.Equals(w.ScenarioId.ToString())).ToList();
            idx = RegisterService.entitlementRepo.GetAll_idaxExport().Where(w => scenarioId.Equals(w.ScenarioId)).ToList();
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
                                            _idx.UserId.Equals(w.UserId)
                                            && (string.IsNullOrEmpty(w.Prefix) || _idx.Prefix.Equals(w.Prefix))
                                            && _idx.Source.Equals(w.Source)
                                            && (string.IsNullOrEmpty(w.Suffix) || _idx.Suffix.Equals(w.Suffix))
                                            && _idx.Asset.Equals(w.Asset)
                                            && (string.IsNullOrEmpty(_idx.ShortDescription) 
                                                || _idx.ShortDescription.Equals(w.ShortDescription))
                                            && (string.IsNullOrEmpty(_idx.LongDescription) 
                                                || _idx.LongDescription.Equals(w.LongDescription))
                                        ).FirstOrDefault();
                        if (_dbo != null)
                        {
                            Assert.AreEqual(_idx.FirstName,_dbo.FirstName, $"UserId = {_idx.UserId} at field: FirstName");
                            Assert.AreEqual(_idx.LastName, _dbo.LastName, $"UserId = {_idx.UserId} at field: LastName");
                            Assert.AreEqual(_idx.EntitlementId, _dbo.EntitlementId, $"UserId = {_idx.UserId} at field: EntitlementId");
                            Assert.AreEqual(_idx.InDeptTemplate, _dbo.InDeptTemplate, $"UserId = {_idx.UserId} at field: InDeptTemplate");
                            Assert.AreEqual(_idx.InRoleTemplate, _dbo.InRoleTemplate, $"UserId = {_idx.UserId} at field: InRoleTemplate");
                        }
                        else
                        {
                            Assert.Fail($"dbo schema does not eixst data for UserId = {_idx.UserId}");
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

