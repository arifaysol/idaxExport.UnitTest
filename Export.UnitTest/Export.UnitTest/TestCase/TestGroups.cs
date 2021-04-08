using Database.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Export.UnitTest
{
    [TestFixture]
    public class TestGroups : TestGeneric
    {
        long _CountOfDbo;
        long _CountOfIdx;
        public override long CountOfDbo { get => _CountOfDbo; set => value = _CountOfDbo; }
        public override long CountOfIdx { get => _CountOfIdx; set => value = _CountOfIdx; }

        IEnumerable<idaxGroups> dbo;
        IEnumerable<IDAX_GROUPS> idx;

        [SetUp]
        public new void SetUp()
        {
            var scenarioId = RegisterService.latest_ScenarioId;
            dbo = RegisterService.groupsRepo.GetAll_dbo().Where(w => scenarioId.Equals(w.ScenarioId.ToString())).ToList();
            idx = RegisterService.groupsRepo.GetAll_idaxExport().Where(w => scenarioId.Equals(w.ScenarioId)).ToList();

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
                                            _idx.GroupId.Equals(w.GroupId)
                                            && _idx.Group.Equals(w.GroupDescription)
                                            && _idx.UserId.Equals(w.UserId)
                                            && _idx.Department.Equals(w.Department)
                                            && _idx.Role.Equals(w.RoleGroup)
                                        ).FirstOrDefault();
                        string key = $"\nGroupId = {_idx.GroupId}\nGroup = {_idx.Group}\nUserId={_idx.UserId}\nDepartment={_idx.Department}\nRole={_idx.Role}";
                        if (_dbo != null)
                        {
                            decimal _NearestDistance, _NextDistance;

                            decimal.TryParse(_idx.NearestDistance.ToString().Remove(_idx.NearestDistance.Length - 1), out _NearestDistance);
                            _NearestDistance = Math.Round(_NearestDistance, 3);
                            decimal.TryParse(_idx.NextDistance.ToString().Remove(_idx.NextDistance.Length - 1), out _NextDistance);
                            _NextDistance = Math.Round(_NextDistance, 3);


                            Assert.AreEqual(_NearestDistance, Math.Round((_dbo.NearestDistance ?? 0),3), $"keys: {key} at field: NearestDistance");
                            Assert.AreEqual(_idx.NextGroup, _dbo.NextGroup, $"keys: {key} at field: NextGroup");
                            Assert.AreEqual(_NextDistance, Math.Round((_dbo.NextDistance ?? 0), 3), $"keys: {key} at field: NextDistance");
                            Assert.AreEqual(_idx.FirstName, _dbo.FirstName, $"keys: {key} at field: FirstName");
                            Assert.AreEqual(_idx.LastName, _dbo.LastName, $"keys: {key} at field: LastName");
                        }
                        else
                        {
                            Assert.Fail($"dbo schema does not eixst data for {key}");
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
