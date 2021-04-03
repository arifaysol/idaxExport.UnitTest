using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    class dbo_schema
    {
    }
    public class idaxScenarios
    {
        [Key, Column(Order = 0)]
        public System.Guid ScenarioId { get; set; }

        public string ScenarioName { get; set; }
        [Key, Column(Order = 1)]
        public System.DateTime UpdateDate { get; set; }
        [Key, Column(Order = 2)]
        public System.Guid UpdateGuid { get; set; }
        public Nullable<System.DateTime> AssignedDate { get; set; }
        public string RunState { get; set; }
        public Nullable<int> TotalAssets { get; set; }
        public Nullable<int> TotalEntitlements { get; set; }
        public Nullable<int> TotalUsers { get; set; }
        public Nullable<int> TotalDepartments { get; set; }
        public Nullable<int> TotalRoles { get; set; }
        public Nullable<int> SingletonAssets { get; set; }
        public Nullable<int> RemovedAssets { get; set; }
        public Nullable<int> AddedAssets { get; set; }
        public Nullable<int> RemovedEntitlements { get; set; }
        public Nullable<int> AddedEntitlements { get; set; }
        public Nullable<int> RemovedUsers { get; set; }
        public Nullable<int> AddedUsers { get; set; }
        public Nullable<int> RemovedDepartments { get; set; }
        public Nullable<int> AddedDepartments { get; set; }
        public Nullable<int> RemovedRoles { get; set; }
        public Nullable<int> AddedRoles { get; set; }
        public string ScenarioSettingsChecksum { get; set; }
        public string ExportType { get; set; }
    }
    public class idaxThreshold
    {
        public string Threshold
        {
            get;
            set;
        }
        public decimal Low
        {
            get;
            set;
        }
        public decimal Medium
        {
            get;
            set;
        }
        public decimal High
        {
            get;
            set;
        }
    }
    public class idaxAssetIdentifier
    {
        public Guid AssetGuid
        {
            get;
            set;
        }
        public int? AssetChecksum
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
        public DateTime? FirstSeen
        {
            get;
            set;
        }
        public DateTime? LastSeen
        {
            get;
            set;
        }
        public Guid ScenarioId
        {
            get;
            set;
        }
    }
    public class idaxDepartmentIdentifier
    {
        public Guid DepartmentGuid
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }
        public Guid ScenarioId
        {
            get;
            set;
        }
        public string DepartmentLevel1
        {
            get;
            set;
        }
        public string DepartmentLevel2
        {
            get;
            set;
        }
        public string DepartmentLevel3
        {
            get;
            set;
        }
        public string DepartmentLevel4
        {
            get;
            set;
        }
        public string DepartmentLevel5
        {
            get;
            set;
        }
        public string DepartmentLevel6
        {
            get;
            set;
        }
        public string DepartmentLevel7
        {
            get;
            set;
        }
        public string DepartmentLevel8
        {
            get;
            set;
        }
        public string DepartmentLevel9
        {
            get;
            set;
        }
        public string DepartmentLevel10
        {
            get;
            set;
        }
        public string DepartmentLevel11
        {
            get;
            set;
        }
        public string DepartmentLevel12
        {
            get;
            set;
        }
        public string DepartmentLevel13
        {
            get;
            set;
        }
        public string DepartmentLevel14
        {
            get;
            set;
        }
        public string DepartmentLevel15
        {
            get;
            set;
        }
        public string DepartmentLevel16
        {
            get;
            set;
        }
        public string DepartmentLevel17
        {
            get;
            set;
        }
        public string DepartmentLevel18
        {
            get;
            set;
        }
        public string DepartmentLevel19
        {
            get;
            set;
        }
        public string DepartmentLevel20
        {
            get;
            set;
        }
        public DateTime? FirstSeen
        {
            get;
            set;
        }
        public DateTime? LastSeen
        {
            get;
            set;
        }
    }
    public class idaxRoleIdentifier
    {
        public Guid RoleGuid
        {
            get;
            set;
        }
        public string RoleDescription
        {
            get;
            set;
        }
        public Guid ScenarioId
        {
            get;
            set;
        }
        public DateTime? FirstSeen
        {
            get;
            set;
        }
        public DateTime? LastSeen
        {
            get;
            set;
        }
    }
    public class idaxAssetRules
    {
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
        public int AssetRuleId
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
        public int Staff
        {
            get;
            set;
        }
        public int Covered
        {
            get;
            set;
        }
        public int NotCovered
        {
            get;
            set;
        }
        public int RuleStaff
        {
            get;
            set;
        }
        public int Added
        {
            get;
            set;
        }
        public decimal? Coverage
        {
            get;
            set;
        }
        public decimal? Inclusion
        {
            get;
            set;
        }
        public decimal? RuleCover
        {
            get;
            set;
        }
        public string RuleDetail
        {
            get;
            set;
        }
        public string RuleType
        {
            get;
            set;
        }
        public string Agg
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
    public class idaxAssets
    {
        public string AssetEnabled
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
        public decimal? AssetWeight
        {
            get;
            set;
        }
        public int? NumUsers
        {
            get;
            set;
        }
        public int? NumDepartments
        {
            get;
            set;
        }
        public int? NumRoles
        {
            get;
            set;
        }
        public bool? Unmatched
        {
            get;
            set;
        }
        public decimal? DeptVar
        {
            get;
            set;
        }
        public decimal? RoleVar
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
    public class idaxDuplicateAssets
    {
        public int DupId
        {
            get;
            set;
        }
        public string DupName
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
    public class idaxEntitlements
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
        public Guid? DepartmentGuid
        {
            get;
            set;
        }
        public int DepartmentEntitlementTotal
        {
            get;
            set;
        }
        public Guid? RoleGuid
        {
            get;
            set;
        }
        public int RoleEntitlementTotal
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
    public class idaxEntitlementMismatches
    {
        public string UserId
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
    public class idaxGroups
    {
        public string GroupId
        {
            get;
            set;
        }
        public string GroupDescription
        {
            get;
            set;
        }
        public decimal? NearestDistance
        {
            get;
            set;
        }
        public string NextGroup
        {
            get;
            set;
        }
        public decimal? NextDistance
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
        public string RoleGroup
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
    public class idaxOrganization
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
        public string RoleDescription
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
        public decimal? GroupRisk
        {
            get;
            set;
        }
        public decimal? AssetRisk
        {
            get;
            set;
        }
        public decimal? DepartmentRisk
        {
            get;
            set;
        }
        public decimal? RoleRisk
        {
            get;
            set;
        }
        public decimal? AggRoleRisk
        {
            get;
            set;
        }
        public decimal? AggDeptRisk
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
        public int? Assignments
        {
            get;
            set;
        }
        public bool DepartmentBigOutlier
        {
            get;
            set;
        }
        public bool DepartmentSingleton
        {
            get;
            set;
        }
        public Guid? DepartmentGuid
        {
            get;
            set;
        }
        public bool RoleBigOutlier
        {
            get;
            set;
        }
        public bool RoleSingleton
        {
            get;
            set;
        }
        public Guid? RoleGuid
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
    public class idaxOrganizationHistory
    {
        public Guid UserOrganizationHistoryGuid
        {
            get;
            set;
        }
        public string UserId
        {
            get;
            set;
        }
        public Guid ScenarioId
        {
            get;
            set;
        }
        public DateTime FirstSeen
        {
            get;
            set;
        }
        public DateTime LastSeen
        {
            get;
            set;
        }
        public DateTime? FirstSeenAssignedDate
        {
            get;
            set;
        }
        public DateTime? LastSeenAssignedDate
        {
            get;
            set;
        }
        public Guid FirstSeenUpdateGuid
        {
            get;
            set;
        }
        public Guid LastSeenUpdateGuid
        {
            get;
            set;
        }
        public bool InLatestRun
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
    public class idaxDepartment
    {
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
        public Guid DepartmentGuid
        {
            get;
            set;
        }
        public DateTime UpdateDate
        {
            get;
            set;
        }
        public int DepartmentUserTotal
        {
            get;
            set;
        }
        public int DepartmentEntitlementsTotal
        {
            get;
            set;
        }
        public int DepartmentUniqueAssetsTotal
        {
            get;
            set;
        }
        public int DepartmentEntitlementsUserMax
        {
            get;
            set;
        }
        public int DepartmentEntitlementsUserMin
        {
            get;
            set;
        }
    }
    public class idaxRole
    {
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
        public Guid RoleGuid
        {
            get;
            set;
        }
        public DateTime UpdateDate
        {
            get;
            set;
        }
        public int RoleUserTotal
        {
            get;
            set;
        }
        public int RoleEntitlementsTotal
        {
            get;
            set;
        }
        public int RoleUniqueAssetsTotal
        {
            get;
            set;
        }
        public int RoleEntitlementsUserMax
        {
            get;
            set;
        }
        public int RoleEntitlementsUserMin
        {
            get;
            set;
        }
    }
    public class idaxTemplateDepartment
    {
        public Guid DepartmentGuid
        {
            get;
            set;
        }
        public string Department
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
        public decimal? Score
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
    public class idaxTemplateRole
    {
        public Guid RoleGuid
        {
            get;
            set;
        }
        public string RoleDescription
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
        public decimal? Score
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
    public class idaxSettings
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
    public class idaxComponentVersion
    {
        public string Component
        {
            get;
            set;
        }
        public string VersionText
        {
            get;
            set;
        }
        public short Major
        {
            get;
            set;
        }
        public short Minor
        {
            get;
            set;
        }
        public short Patch
        {
            get;
            set;
        }
        public string Label
        {
            get;
            set;
        }
    }
}
