using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Repositories
{
    public interface IBaseRepo<DBO, IDAXEXPORT>
        where DBO : class
        where IDAXEXPORT : class
    {
        IEnumerable<DBO> GetAll_dbo();
        IEnumerable<IDAXEXPORT> GetAll_idaxExport();
    }
    public abstract class BaseRepo<DBO, IDAXEXPORT> : IBaseRepo<DBO, IDAXEXPORT>
        where DBO : class
        where IDAXEXPORT : class
    {
        DbContext context;
        DbSet<DBO> _dbo;
        DbSet<IDAXEXPORT> _idaxexport;

        public BaseRepo()
        {
            context = new MyDbContext();
            _dbo = context.Set<DBO>();
            _idaxexport = context.Set<IDAXEXPORT>();
        }

        public virtual IEnumerable<DBO> GetAll_dbo()
        {
            return _dbo.AsEnumerable();
        }

        public virtual IEnumerable<IDAXEXPORT> GetAll_idaxExport()
        {
            return _idaxexport.AsEnumerable();
        }
    }

    public interface IScenarioRepo : IBaseRepo<idaxScenarios, IDAX_SCENARIOS>
    {

    }
    public interface ISettingRepo : IBaseRepo<idaxSettings, IDAX_SETTINGS>
    {

    }
    public interface IEntitlementsRepo : IBaseRepo<idaxEntitlements, IDAX_ENTITLEMENTS>
    {

    }
    public interface IAssetRulesRepo : IBaseRepo<idaxAssetRules, IDAX_ASSET_RULES>
    {

    }
    public interface IAssetsRepo : IBaseRepo<idaxAssets, IDAX_ASSETS>
    {

    }

    public interface IDepartmentRepo : IBaseRepo<idaxDepartment, IDAX_MAP_DEPARTMENT>
    {

    }
    public interface IDepartmentIdentifierRepo : IBaseRepo<idaxDepartmentIdentifier, IDAX_MAP_DEPARTMENT>
    {

    }
    public interface IDuplicateAssetsRepo : IBaseRepo<idaxDuplicateAssets, IDAX_DUPLICATE_ASSETS>
    {

    }
    public interface IEntitlementMismatchesRepo : IBaseRepo<idaxEntitlementMismatches, IDAX_ENTITLEMENTS>
    {

    }
    public interface IGroupsRepo : IBaseRepo<idaxGroups, IDAX_GROUPS>
    {

    }
    public interface IOrganizationRepo : IBaseRepo<idaxOrganization, IDAX_ORGANIZATION>
    {

    }
    public interface IOrganizationHistoryRepo : IBaseRepo<idaxOrganizationHistory, IDAX_ORGANIZATION>
    {

    }
    public interface IRoleRepo : IBaseRepo<idaxRole, IDAX_MAP_ROLE>
    {

    }
    public interface IRoleIdentifierRepo : IBaseRepo<idaxRoleIdentifier, IDAX_MAP_ROLE>
    {

    }
    public interface ITemplateDepartmentRepo : IBaseRepo<idaxTemplateDepartment, IDAX_TEMPLATE_DEPARTMENT>
    {

    }
    public interface ITemplateRoleRepo : IBaseRepo<idaxTemplateRole, IDAX_TEMPLATE_ROLE>
    {

    }
    public interface IThresholdRepo : IBaseRepo<idaxThreshold, IDAX_ENTITLEMENTS>
    {

    }
    public interface IAssetIdentifierRepo : IBaseRepo<idaxAssetIdentifier, IDAX_ENTITLEMENTS>
    {

    }
    public interface IComponentVersionRepo : IBaseRepo<idaxComponentVersion, IDAX_ENTITLEMENTS>
    {

    }
}
