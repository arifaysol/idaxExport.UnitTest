using Database.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            _CountOfDbo = RegisterService.groupsRepo.GetAll_dbo().Count();
            _CountOfIdx = RegisterService.groupsRepo.GetAll_idaxExport().Count();

            dbo = RegisterService.groupsRepo.GetAll_dbo().Where(w => scenarioId.Equals(w.ScenarioId.ToString())).ToList();
            idx = RegisterService.groupsRepo.GetAll_idaxExport().Where(w => scenarioId.Equals(w.ScenarioId)).ToList();
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
                            decimal _NearestDistance, _DeptVar, _RoleVar;
                            decimal.TryParse(_idx.NearestDistance, out _NearestDistance);
                            string trunc = ((trunc = _NearestDistance.ToString("f16")).Substring(0, trunc.Length - 11));
                            var ___NearestDistance = String.Format("{0:N2}%", _NearestDistance);

                            //decimal.TryParse(_idx.DeptVar, out _DeptVar);
                            //decimal.TryParse(_idx.RoleVar, out _RoleVar);

                            //int _NumUsers, _NumDepartments, _NumRoles;
                            //int.TryParse(_idx.NumUsers, out _NumUsers);
                            //int.TryParse(_idx.NumDepartments, out _NumDepartments);
                            //int.TryParse(_idx.NumRoles, out _NumRoles);

                            //bool _Unmatched;
                            //bool.TryParse(_idx.Unmatched, out _Unmatched);

                            //Assert.AreEqual(_idx.Enabled, _dbo.AssetEnabled, $"keys: {key} at field: AssetEnabled");
                            //Assert.AreEqual(_NumUsers, _dbo.NumUsers, $"keys: {key} at field: NumUsers");
                            //Assert.IsTrue(Math.Round(_NearestDistance, 3, MidpointRounding.AwayFromZero)- (_dbo.NearestDistance ?? 0) <= 0.001M, $"keys: {key} at field: NearestDistance");
                            Assert.AreEqual(Math.Round(decimal.Parse(trunc),3), (_dbo.NearestDistance ?? 0), $"keys: {key} at field: NearestDistance");
                            //Assert.AreEqual(_NumRoles, _dbo.NumRoles, $"keys: {key} at field: NumRoles");
                            //Assert.AreEqual(_Unmatched, _dbo.Unmatched, $"keys: {key} at field: Unmatched");
                            //Assert.AreEqual(Math.Round(_DeptVar, 3, MidpointRounding.AwayFromZero), Math.Round(_dbo.DeptVar, 3, MidpointRounding.AwayFromZero), $"keys: {key} at field: DeptVar");
                            //Assert.AreEqual(Math.Round(_RoleVar, 3, MidpointRounding.AwayFromZero), Math.Round(_dbo.RoleVar, 3, MidpointRounding.AwayFromZero), $"keys: {key} at field: RoleVar");
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
