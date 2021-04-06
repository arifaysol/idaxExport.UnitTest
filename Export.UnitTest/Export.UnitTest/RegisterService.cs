using Database.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Export.UnitTest
{
    public static class RegisterService
    {
        static ServiceProvider myServices { get; set; }
        public static void Register()
        {
            myServices = new ServiceCollection()
                    .AddSingleton<IScenarioRepo, ScenarioRepo>()
                    .AddSingleton<ISettingRepo, SettingRepo>()
                    .AddSingleton<IEntitlementsRepo, EntitlementRepo>()
                    .AddSingleton<IAssetsRepo, AssetsRepo>()
                    .AddSingleton<IDuplicateAssetsRepo, DuplicateAssetsRepo>()
                    .AddSingleton<IGroupsRepo, GroupsRepo>()
                    .AddSingleton<IOrganizationRepo, OrganizationRepo>()
                    .AddSingleton<ITemplateDepartmentRepo, TemplateDepartmentRepo>()
                    .AddSingleton<ITemplateRoleRepo, TemplateRoleRepo>()
                .BuildServiceProvider();

            scenarioRepo = myServices.GetService<IScenarioRepo>();
            settingRepo = myServices.GetService<ISettingRepo>();
            entitlementRepo = myServices.GetService<IEntitlementsRepo>();
            assetsRepo = myServices.GetService<IAssetsRepo>();
            duplicateAssetsRepo  = myServices.GetService<IDuplicateAssetsRepo>();
            groupsRepo = myServices.GetService<IGroupsRepo>();
            organizationRepo = myServices.GetService<IOrganizationRepo>();
            templateDepartmentRepo = myServices.GetService<ITemplateDepartmentRepo>();
            templateRoleRepo = myServices.GetService<ITemplateRoleRepo>();
            WasInjected = true;
            latest_ScenarioId = scenarioRepo.GetAll_idaxExport().OrderByDescending(o => o.UpdateDate).FirstOrDefault().ScenarioId;
        }

        public static bool WasInjected { get; private set; } = false;
        public static string latest_ScenarioId { get; private set; }
        public static IScenarioRepo scenarioRepo { get; private set; }
        public static ISettingRepo settingRepo { get; private set; }
        public static IEntitlementsRepo entitlementRepo { get; private set; }
        public static IAssetsRepo assetsRepo { get; private set; }
        public static IDuplicateAssetsRepo duplicateAssetsRepo { get; private set; }
        public static IGroupsRepo groupsRepo { get; private set; }
        public static IOrganizationRepo organizationRepo { get; private set; }
        public static ITemplateDepartmentRepo templateDepartmentRepo { get; private set; }
        public static ITemplateRoleRepo templateRoleRepo { get; private set; }
    }
}
