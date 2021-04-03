using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    class idaxExport_shema
    {
    }

    [Table("IDAX_ASSET_RULES", Schema = "idaxExport")]
    public class IDAX_ASSET_RULES
    {
        public int AssetRuleId
        {
            get;
            set;
        }
        public string Asset
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public string Prefix
        {
            get;
            set;
        }
        public string Suffix
        {
            get;
            set;
        }
        public string Staff
        {
            get;
            set;
        }
        public string Mismatches
        {
            get;
            set;
        }
        public string Covered
        {
            get;
            set;
        }
        public string Not_Covered
        {
            get;
            set;
        }
        public string Rule_Staff
        {
            get;
            set;
        }
        public string Added
        {
            get;
            set;
        }
        public string Coverage
        {
            get;
            set;
        }
        public string Inclusion
        {
            get;
            set;
        }
        public string Rule_Cover
        {
            get;
            set;
        }
        public string Rule
        {
            get;
            set;
        }
        public string RuleReference
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public string Agg
        {
            get;
            set;
        }
        public string RuleOwner
        {
            get;
            set;
        }
        public string RuleSource
        {
            get;
            set;
        }
        public string Compliance
        {
            get;
            set;
        }
        public string AllowDeny
        {
            get;
            set;
        }
        public string ShortDescription
        {
            get;
            set;
        }
        public string LongDescription
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_ASSET_RULE_PEOPLE", Schema = "idaxExport")]
    public class IDAX_ASSET_RULE_PEOPLE
    {
        public int AssetRuleId
        {
            get;
            set;
        }
        public string UserId
        {
            get;
            set;
        }
        public bool? InRule
        {
            get;
            set;
        }
        public bool? AssignedAsset
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_ASSET_RULE_DETAILS", Schema = "idaxExport")]
    public class IDAX_ASSET_RULE_DETAILS
    {
        public int? AssetRuleId
        {
            get;
            set;
        }
        public string RuleAttrCategory
        {
            get;
            set;
        }
        public string RuleAttrValue
        {
            get;
            set;
        }
        public int? RuleDeptLevel
        {
            get;
            set;
        }
        public int? Order
        {
            get;
            set;
        }
        public bool? IsMandatory
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_ASSETS", Schema = "idaxExport")]
    public class IDAX_ASSETS
    {
        public string Enabled
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public string Asset
        {
            get;
            set;
        }
        public string Prefix
        {
            get;
            set;
        }
        public string Suffix
        {
            get;
            set;
        }
        public string Weight
        {
            get;
            set;
        }
        public string NumUsers
        {
            get;
            set;
        }
        public string NumDepartments
        {
            get;
            set;
        }
        public string NumRoles
        {
            get;
            set;
        }
        public string Unmatched
        {
            get;
            set;
        }
        public string DeptVar
        {
            get;
            set;
        }
        public string RoleVar
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_DUPLICATE_ASSETS", Schema = "idaxExport")]
    public class IDAX_DUPLICATE_ASSETS
    {
        public string DupId
        {
            get;
            set;
        }
        public string DupName
        {
            get;
            set;
        }
        public string Asset
        {
            get;
            set;
        }
        public string Prefix
        {
            get;
            set;
        }
        public string Suffix
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_ENTITLEMENTS", Schema = "idaxExport")]
    public class IDAX_ENTITLEMENTS
    {
        public string UserId
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Prefix
        {
            get;
            set;
        }
        public string Suffix
        {
            get;
            set;
        }
        public string Asset
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public string ShortDescription
        {
            get;
            set;
        }
        public string LongDescription
        {
            get;
            set;
        }
        public string EntitlementId
        {
            get;
            set;
        }
        public bool? InDeptTemplate
        {
            get;
            set;
        }
        public bool? InRoleTemplate
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_GROUPS", Schema = "idaxExport")]
    public class IDAX_GROUPS
    {
        public string GroupId
        {
            get;
            set;
        }
        public string Group
        {
            get;
            set;
        }
        public string NearestDistance
        {
            get;
            set;
        }
        public string NextGroup
        {
            get;
            set;
        }
        public string NextDistance
        {
            get;
            set;
        }
        public string UserId
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }
        public string Role
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_MAP_DEPARTMENT", Schema = "idaxExport")]
    public class IDAX_MAP_DEPARTMENT
    {
        public string MapGroup
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_MAP_ROLE", Schema = "idaxExport")]
    public class IDAX_MAP_ROLE
    {
        public string MapGroup
        {
            get;
            set;
        }
        public string Role
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_ORGANIZATION", Schema = "idaxExport")]
    public class IDAX_ORGANIZATION
    {
        public string UserId
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string ManagerId
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }
        public string Role
        {
            get;
            set;
        }
        public string MapDepartment
        {
            get;
            set;
        }
        public string MapRole
        {
            get;
            set;
        }
        public string GroupRisk
        {
            get;
            set;
        }
        public string AssetRisk
        {
            get;
            set;
        }
        public string DepartmentRisk
        {
            get;
            set;
        }
        public string RoleRisk
        {
            get;
            set;
        }
        public string AggRoleRisk
        {
            get;
            set;
        }
        public string AggDeptRisk
        {
            get;
            set;
        }
        public string AssignedGroup
        {
            get;
            set;
        }
        public string NextNearestGroup
        {
            get;
            set;
        }
        public string Assignments
        {
            get;
            set;
        }
        public int? DeptTemplateCount
        {
            get;
            set;
        }
        public int? UserDeptTemplateCount
        {
            get;
            set;
        }
        public int? DeptAssetCount
        {
            get;
            set;
        }
        public double? DeptCAT
        {
            get;
            set;
        }
        public int? RoleTemplateCount
        {
            get;
            set;
        }
        public int? UserRoleTemplateCount
        {
            get;
            set;
        }
        public int? RoleAssetCount
        {
            get;
            set;
        }
        public double? RoleCAT
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_REVIEW", Schema = "idaxExport")]
    public class IDAX_REVIEW
    {
        public string UserId
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }
        public string Role
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public string Prefix
        {
            get;
            set;
        }
        public string Asset
        {
            get;
            set;
        }
        public string Suffix
        {
            get;
            set;
        }
        public string Priority
        {
            get;
            set;
        }
        public string Action
        {
            get;
            set;
        }
        public string Dept_Risk
        {
            get;
            set;
        }
        public string Role_Risk
        {
            get;
            set;
        }
        public string Dept_Profile
        {
            get;
            set;
        }
        public string Role_Profile
        {
            get;
            set;
        }
        public string Asset_Weighting
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }
    
    [Table("IDAX_SCENARIOS", Schema = "idaxExport")]
    public class IDAX_SCENARIOS
    {
        [Key]
        public string ScenarioId
        {
            get;
            set;
        }
        public string ScenarioName
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public string ExportType
        {
            get;
            set;
        }
    }

    [Table("IDAX_TEMPLATE_DEPARTMENT", Schema = "idaxExport")]
    public class IDAX_TEMPLATE_DEPARTMENT
    {
        public string Department
        {
            get;
            set;
        }
        public string Prefix
        {
            get;
            set;
        }
        public string Asset
        {
            get;
            set;
        }
        public string Suffix
        {
            get;
            set;
        }
        public string Score
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_TEMPLATE_ROLE", Schema = "idaxExport")]
    public class IDAX_TEMPLATE_ROLE
    {
        public string Role
        {
            get;
            set;
        }
        public string Prefix
        {
            get;
            set;
        }
        public string Suffix
        {
            get;
            set;
        }
        public string Asset
        {
            get;
            set;
        }
        public string Score
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_ASSET_RULE_SETTING", Schema = "idaxExport")]
    public class IDAX_ASSET_RULE_SETTING
    {
        public string MinimumEntitlementsPerAsset
        {
            get;
            set;
        }
        public string AllStaffThreshold
        {
            get;
            set;
        }
        public string ExcessThreshold
        {
            get;
            set;
        }
        public string Coverage
        {
            get;
            set;
        }
        public string Inclusion
        {
            get;
            set;
        }
        public string MinStaffPerAttribute
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("IDAX_CLIENT_RULES", Schema = "idaxExport")]
    public class IDAX_CLIENT_RULES
    {
        public string ClientRuleReference
        {
            get;
            set;
        }
        public string Asset
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public string Prefix
        {
            get;
            set;
        }
        public string Suffix
        {
            get;
            set;
        }
        public string Role
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }
        public string Location
        {
            get;
            set;
        }
        public string AssetAttributes
        {
            get;
            set;
        }
        public string RuleOwner
        {
            get;
            set;
        }
        public string ScenarioId
        {
            get;
            set;
        }
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }

    [Table("idaxV3Assignments", Schema = "idaxExport")]
    public class idaxV3Assignments
    {
        public string UserId
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public int? AssetChecksum
        {
            get;
            set;
        }
        public Guid AssetGuid
        {
            get;
            set;
        }
        public Guid AssetRunGuid
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public string Asset
        {
            get;
            set;
        }
        public string Prefix
        {
            get;
            set;
        }
        public string Suffix
        {
            get;
            set;
        }
        public string ShortDescription
        {
            get;
            set;
        }
        public string LongDescription
        {
            get;
            set;
        }
        public string EntitlementId
        {
            get;
            set;
        }
        public Guid DepartmentGuid
        {
            get;
            set;
        }
        public int DepartmentAssignmentTotal
        {
            get;
            set;
        }
        public Guid RoleGuid
        {
            get;
            set;
        }
        public int RoleAssignmentTotal
        {
            get;
            set;
        }
        public Guid ScenarioId
        {
            get;
            set;
        }
        public Guid UpdateGuid
        {
            get;
            set;
        }
        public DateTime UpdateDate
        {
            get;
            set;
        }
    }

    [Table("idaxV3Scenarios", Schema = "idaxExport")]
    public class idaxV3Scenarios
    {
        public Guid ScenarioId
        {
            get;
            set;
        }
        public string ScenarioName
        {
            get;
            set;
        }
        public DateTime UpdateDate
        {
            get;
            set;
        }
        public Guid UpdateGuid
        {
            get;
            set;
        }
        public DateTime? AssignedDate
        {
            get;
            set;
        }
        public string RunState
        {
            get;
            set;
        }
        public int? TotalAssets
        {
            get;
            set;
        }
        public int? TotalAssignments
        {
            get;
            set;
        }
        public int? TotalUsers
        {
            get;
            set;
        }
        public int? TotalDepartments
        {
            get;
            set;
        }
        public int? TotalRoles
        {
            get;
            set;
        }
        public int? SingletonAssets
        {
            get;
            set;
        }
        public int? RemovedAssets
        {
            get;
            set;
        }
        public int? AddedAssets
        {
            get;
            set;
        }
        public int? RemovedEntitlements
        {
            get;
            set;
        }
        public int? AddedEntitlements
        {
            get;
            set;
        }
        public int? RemovedUsers
        {
            get;
            set;
        }
        public int? AddedUsers
        {
            get;
            set;
        }
        public int? RemovedDepartments
        {
            get;
            set;
        }
        public int? AddedDepartments
        {
            get;
            set;
        }
        public int? RemovedRoles
        {
            get;
            set;
        }
        public int? AddedRoles
        {
            get;
            set;
        }
        public string ScenarioSettingsChecksum
        {
            get;
            set;
        }
        public string ExportType
        {
            get;
            set;
        }
    }
    
    [Table("IDAX_SETTINGS", Schema = "idaxExport")]
    public class IDAX_SETTINGS
    {
        [Key, Column(Order = 0)]
        public string SettingName
        {
            get;
            set;
        }
        [Key, Column(Order = 1)]
        public string SettingValue
        {
            get;
            set;
        }
        [Key, Column(Order = 2)]
        public string ScenarioId
        {
            get;
            set;
        }
        [Key, Column(Order = 3)]
        public string UpdateGuid
        {
            get;
            set;
        }
        public DateTime? UpdateDate
        {
            get;
            set;
        }
    }
}
