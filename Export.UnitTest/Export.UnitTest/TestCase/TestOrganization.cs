using Database.Models;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Export.UnitTest
{
    [TestFixture]
    public class TestOrganization : TestGeneric
    {
        long _CountOfDbo;
        long _CountOfIdx;
        string scenarioId;
        public override long CountOfDbo { get => _CountOfDbo; set => value = _CountOfDbo; }
        public override long CountOfIdx { get => _CountOfIdx; set => value = _CountOfIdx; }

        IEnumerable<idaxOrganization> dbo_org;
        IEnumerable<IDAX_ORGANIZATION> idx_org;

        IEnumerable<idaxEntitlements> dbo_ent;
        IEnumerable<IDAX_ENTITLEMENTS> idx_ent;

        IEnumerable<IDAX_TEMPLATE_DEPARTMENT> idx_tmplt_dept;
        IEnumerable<idaxTemplateDepartment> dbo_tmplt_dept;

        IEnumerable<IDAX_TEMPLATE_ROLE> idx_tmplt_role;
        IEnumerable<idaxTemplateRole> dbo_tmplt_role;
        [SetUp]
        public new void SetUp()
        {
            scenarioId = RegisterService.latest_ScenarioId;
            dbo_org = RegisterService.organizationRepo.GetAll_dbo().Where(w => scenarioId.Equals(w.ScenarioId.ToString())).ToList();
            idx_org = RegisterService.organizationRepo.GetAll_idaxExport().Where(w => scenarioId.Equals(w.ScenarioId)).ToList();

            _CountOfDbo = dbo_org.Count();
            _CountOfIdx = idx_org.Count();

            idx_ent = RegisterService.entitlementRepo.GetAll_idaxExport().Where(w => scenarioId.Equals(w.ScenarioId)).ToList();
            dbo_ent = RegisterService.entitlementRepo.GetAll_dbo().Where(w => scenarioId.Equals(w.ScenarioId)).ToList();

            idx_tmplt_dept = RegisterService.templateDepartmentRepo.GetAll_idaxExport().Where(w => scenarioId.Equals(w.ScenarioId)).ToList();

        }

        [TestCase]
        public override async Task CompareLineBaseLineLatestRows()
        {
            await Task.Run(() =>
            {
                if (dbo_org != null && idx_org != null)
                {

                    foreach (var _idx in idx_org)
                    {
                        var _dbo = dbo_org.Where(w => _idx.UserId.Equals(w.UserId)
                                            && _idx.UpdateGuid.Equals(w.UpdateGuid.ToString())
                                        ).FirstOrDefault();
                        if (_dbo != null)
                        {
                            decimal _GroupRisk, _AssetRisk, _DepartmentRisk, _RoleRisk, _AggRoleRisk, _AggDeptRisk;
                            int _Assignments;
                            decimal.TryParse(_idx.GroupRisk, out _GroupRisk);
                            decimal.TryParse(_idx.AssetRisk, out _AssetRisk);
                            decimal.TryParse(_idx.DepartmentRisk, out _DepartmentRisk);
                            decimal.TryParse(_idx.RoleRisk, out _RoleRisk);
                            decimal.TryParse(_idx.AggRoleRisk, out _AggRoleRisk);
                            decimal.TryParse(_idx.AggDeptRisk, out _AggDeptRisk);
                            int.TryParse(_idx.Assignments, out _Assignments);

                            Assert.AreEqual(_idx.FirstName, _dbo.FirstName, $"UserId = {_idx.UserId} at field: FirstName");
                            Assert.AreEqual(_idx.LastName, _dbo.LastName, $"UserId = {_idx.UserId} at field: LastName");
                            Assert.AreEqual(_idx.ManagerId, _dbo.ManagerId, $"UserId = {_idx.UserId} at field: ManagerId");
                            Assert.AreEqual(_idx.Department, _dbo.Department, $"UserId = {_idx.UserId} at field: Department");
                            Assert.AreEqual(_idx.Role, _dbo.RoleDescription, $"UserId = {_idx.UserId} at field: Role");
                            Assert.AreEqual(_idx.MapDepartment, _dbo.MapDepartment, $"UserId = {_idx.UserId} at field: MapDepartment");
                            Assert.AreEqual(_idx.MapRole, _dbo.MapRole, $"UserId = {_idx.UserId} at field: MapRole");
                            Assert.AreEqual(Math.Round(_GroupRisk, 3), _dbo.GroupRisk, $"UserId = {_idx.UserId} at field: GroupRisk");
                            Assert.IsTrue((Math.Round(_AssetRisk, 3, MidpointRounding.AwayFromZero) - Math.Round(_dbo.AssetRisk, 3, MidpointRounding.AwayFromZero)) <= 0.001M, $"UserId = {_idx.UserId} at field: AssetRisk");
                            Assert.AreEqual(Math.Round(_DepartmentRisk, 3), _dbo.DepartmentRisk, $"UserId = {_idx.UserId} at field: DepartmentRisk");
                            Assert.AreEqual(Math.Round(_RoleRisk, 3), _dbo.RoleRisk, $"UserId = {_idx.UserId} at field: RoleRisk");
                            Assert.AreEqual(Math.Round(_AggRoleRisk, 3), _dbo.AggRoleRisk, $"UserId = {_idx.UserId} at field: AggRoleRisk");
                            Assert.AreEqual(Math.Round(_AggDeptRisk, 3), _dbo.AggDeptRisk, $"UserId = {_idx.UserId} at field: AggDeptRisk");
                            Assert.AreEqual(_idx.AssignedGroup, _dbo.AssignedGroup, $"UserId = {_idx.UserId} at field: AssignedGroup");
                            Assert.AreEqual(_idx.NextNearestGroup, _dbo.NextNearestGroup, $"UserId = {_idx.UserId} at field: NextNearestGroup");
                            Assert.AreEqual(_Assignments, _dbo.Assignments, $"UserId = {_idx.UserId} at field: Assignments");
                            Assert.AreEqual(_idx.DeptTemplateCount, _dbo.DeptTemplateCount, $"UserId = {_idx.UserId} at field: DeptTemplateCount");
                            Assert.AreEqual(_idx.UserDeptTemplateCount, _dbo.UserDeptTemplateCount, $"UserId = {_idx.UserId} at field: UserDeptTemplateCount");
                            Assert.AreEqual(_idx.DeptAssetCount, _dbo.DeptAssetCount, $"UserId = {_idx.UserId} at field: DeptAssetCount");
                            Assert.AreEqual(_idx.DeptCAT, _dbo.DeptCAT, $"UserId = {_idx.UserId} at field: DeptCAT");
                            Assert.AreEqual(_idx.RoleTemplateCount, _dbo.RoleTemplateCount, $"UserId = {_idx.UserId} at field: RoleTemplateCount");
                            Assert.AreEqual(_idx.UserRoleTemplateCount, _dbo.UserRoleTemplateCount, $"UserId = {_idx.UserId} at field: UserRoleTemplateCount");
                            Assert.AreEqual(_idx.RoleAssetCount, _dbo.RoleAssetCount, $"UserId = {_idx.UserId} at field: RoleAssetCount");
                            Assert.AreEqual(_idx.RoleCAT, _dbo.RoleCAT, $"UserId = {_idx.UserId} at field: RoleCAT");
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

        [TestCase]
        public async Task Compare_CountOf_Assignment_idx_schema()
        {
            
            await Task.Run(() =>
            {
                foreach (var item in idx_org)
                {
                    var _res_idx_ent = idx_ent.Where(w => item.UserId.Equals(w.UserId)).Count();
                    Assert.AreEqual(item.Assignments, _res_idx_ent.ToString(),$"Key = {item.UserId}");
                }
            });
        }

        [TestCase]
        public async Task Compare_CountOf_UserDeptTemplateCount_idx_schema()
        {

            await Task.Run(() =>
            {
                foreach (var item in idx_org)
                {
                    var _res_idx_ent = idx_ent.Where(w => 
                                                item.UserId.Equals(w.UserId) 
                                                && w.InDeptTemplate.HasValue 
                                                && w.InDeptTemplate.Value.Equals(true)
                                            ).Count();
                    Assert.AreEqual(item.UserDeptTemplateCount, _res_idx_ent, $"Key = {item.UserId}");
                }
            });
        }

        [TestCase]
        public async Task Compare_CountOf_DeptTemplateCount_idx_schema()
        {

            await Task.Run(() =>
            {
                foreach (var item in idx_org)
                {
                    var _res_idx_ent = idx_tmplt_dept.Where(w =>
                                                item.Department.Equals(w.Department)
                                                && !w.Asset.Equals("-")
                                            ).Count();
                    Assert.AreEqual(item.DeptTemplateCount, _res_idx_ent, $"Key = {item.UserId}");
                }
            });
        }

        [TestCase]
        public async Task Compare_CountOf_DeptAssetCount_idx_schema()
        {

            await Task.Run(() =>
            {
                var res_grouped = idx_org.GroupBy(g => g.Department).Select(s => new
                {
                    s.Key,
                    DeptAssetCount = s.FirstOrDefault()?.DeptAssetCount,
                    datas = s.Select(s=>s.UserId).ToArray()
                });


                foreach (var item in res_grouped)
                {
                    var check = idx_ent.Where(w => item.datas.Contains(w.UserId))
                                        .GroupBy(g => new
                                        {
                                            g.Asset,
                                            g.Source,
                                            g.Prefix,
                                            g.Suffix,
                                            g.ShortDescription,
                                            g.LongDescription
                                        }).Count();
                    Assert.AreEqual(item.DeptAssetCount, check, $"Key = {item.Key}");
                }
            });
        }

        [TestCase]
        public async Task Compare_CountOf_UserRoleTemplateCount_idx_schema()
        {

            await Task.Run(() =>
            {
                foreach (var item in idx_org)
                {
                    var _res_idx_ent = idx_ent.Where(w =>
                                                item.UserId.Equals(w.UserId)
                                                && w.InRoleTemplate.HasValue
                                                && w.InRoleTemplate.Value.Equals(true)
                                            ).Count();
                    Assert.AreEqual(item.UserRoleTemplateCount, _res_idx_ent, $"Key = {item.UserId}");
                }
            });
        }

        // Missing Compare_CountOf_RoleTemplateCount_idx_schema

        [TestCase]
        public async Task Compare_CountOf_RoleAssetCount_idx_schema()
        {

            await Task.Run(() =>
            {
                var res_grouped = idx_org.GroupBy(g => g.Role).Select(s => new
                {
                    s.Key,
                    RoleAssetCount = s.FirstOrDefault()?.RoleAssetCount,
                    datas = s.Select(s => s.UserId).ToArray()
                });


                foreach (var item in res_grouped)
                {
                    var check = idx_ent.Where(w => item.datas.Contains(w.UserId))
                                        .GroupBy(g => new
                                        {
                                            g.Asset,
                                            g.Source,
                                            g.Prefix,
                                            g.Suffix,
                                            g.ShortDescription,
                                            g.LongDescription
                                        }).Count();
                    Assert.AreEqual(item.RoleAssetCount, check, $"Key = {item.Key}");
                }
            });
        }
    }
}


