using Database.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Export.UnitTest
{
    [TestFixture]
    public class TestAssets : TestGeneric
    {
        long _CountOfDbo;
        long _CountOfIdx;
        public override long CountOfDbo { get => _CountOfDbo; set => value = _CountOfDbo; }
        public override long CountOfIdx { get => _CountOfIdx; set => value = _CountOfIdx; }

        IEnumerable<idaxAssets> dbo;
        IEnumerable<IDAX_ASSETS> idx;

        [SetUp]
        public new void SetUp()
        {
            var scenarioId = RegisterService.latest_ScenarioId;
            _CountOfDbo = RegisterService.assetsRepo.GetAll_dbo().Count();
            _CountOfIdx = RegisterService.assetsRepo.GetAll_idaxExport().Count();

            dbo = RegisterService.assetsRepo.GetAll_dbo().Where(w => scenarioId.Equals(w.ScenarioId.ToString())).ToList();
            idx = RegisterService.assetsRepo.GetAll_idaxExport().Where(w => scenarioId.Equals(w.ScenarioId)).ToList();
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
                                            (string.IsNullOrEmpty(w.Prefix) || _idx.Prefix.Equals(w.Prefix))
                                            && _idx.Source.Equals(w.Source)
                                            && (string.IsNullOrEmpty(w.Suffix) || _idx.Suffix.Equals(w.Suffix))
                                            && _idx.Asset.Equals(w.Asset)
                                            && _idx.UpdateGuid.Equals(w.UpdateGuid.ToString())
                                        ).FirstOrDefault();
                        string key = $"Asset = {_idx.Asset}\nSource = {_idx.Source}\nPrefix={_idx.Prefix}\nSuffix={_idx.Suffix}";
                        if (_dbo != null)
                        {
                            decimal _Weight, _DeptVar, _RoleVar;
                            decimal.TryParse(_idx.Weight, out _Weight);
                            decimal.TryParse(_idx.DeptVar, out _DeptVar);
                            decimal.TryParse(_idx.RoleVar, out _RoleVar);

                            int _NumUsers, _NumDepartments, _NumRoles;
                            int.TryParse(_idx.NumUsers, out _NumUsers);
                            int.TryParse(_idx.NumDepartments, out _NumDepartments);
                            int.TryParse(_idx.NumRoles, out _NumRoles);

                            bool _Unmatched;
                            bool.TryParse(_idx.Unmatched, out _Unmatched);

                            Assert.AreEqual(_idx.Enabled, _dbo.AssetEnabled, $"keys: {key} at field: AssetEnabled");
                            Assert.AreEqual(Math.Round(_Weight,3,MidpointRounding.AwayFromZero), Math.Round(_dbo.AssetWeight / 10, 3, MidpointRounding.AwayFromZero) , $"keys: {key} at field: Weight");
                            Assert.AreEqual(_NumUsers, _dbo.NumUsers, $"keys: {key} at field: NumUsers");
                            Assert.AreEqual(_NumDepartments, _dbo.NumDepartments, $"keys: {key} at field: NumDepartments");
                            Assert.AreEqual(_NumRoles, _dbo.NumRoles, $"keys: {key} at field: NumRoles");
                            Assert.AreEqual(_Unmatched, _dbo.Unmatched, $"keys: {key} at field: Unmatched");
                            Assert.AreEqual(Math.Round(_DeptVar,3,MidpointRounding.AwayFromZero), Math.Round(_dbo.DeptVar,3,MidpointRounding.AwayFromZero), $"keys: {key} at field: DeptVar");
                            Assert.AreEqual(Math.Round(_RoleVar, 3, MidpointRounding.AwayFromZero), Math.Round(_dbo.RoleVar, 3, MidpointRounding.AwayFromZero), $"keys: {key} at field: RoleVar");
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
