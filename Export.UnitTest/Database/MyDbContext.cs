using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<idaxSettings>()
                .HasKey(e => new 
                    { 
                        e.ScenarioId
                        , e.SettingName
                        , e.SettingValue
                        ,e.UpdateGuid
                    });
            modelBuilder.Entity<IDAX_SETTINGS>()
                .HasKey(e => new
                    {
                        e.ScenarioId
                        ,e.SettingName
                        ,e.SettingValue
                        ,e.UpdateGuid
                    });
            modelBuilder.Entity<idaxEntitlements>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.UserId,
                    e.Asset,
                    e.Source,
                    e.Prefix,
                    e.Suffix,
                    e.UpdateGuid
                });

            modelBuilder.Entity<IDAX_ENTITLEMENTS>()
                .HasKey(e => new
                    {
                        e.ScenarioId
                        ,e.UserId
                        ,e.Asset
                        ,e.Source
                        ,e.Prefix
                        ,e.Suffix
                        ,e.UpdateGuid
                    });
            modelBuilder.Entity<idaxAssets>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.Asset,
                    e.Source,
                    e.Prefix,
                    e.Suffix,
                    e.UpdateGuid
                });
            modelBuilder.Entity<IDAX_ASSETS>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.Asset,
                    e.Source,
                    //e.Prefix,
                    //e.Suffix,
                    e.UpdateGuid
                });
            modelBuilder.Entity<idaxDuplicateAssets>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.Asset,
                    e.Source,
                    e.Prefix,
                    e.Suffix,
                    e.UpdateGuid
                });
            modelBuilder.Entity<IDAX_DUPLICATE_ASSETS>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.Asset,
                    e.UpdateGuid
                });
            modelBuilder.Entity<idaxGroups>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.GroupId,
                    e.UserId,
                    e.Department,
                    e.RoleGroup,
                    e.UpdateGuid
                });
            modelBuilder.Entity<IDAX_GROUPS>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.GroupId,
                    e.UserId,
                    e.Department,
                    e.Role,
                    e.UpdateGuid
                });
            modelBuilder.Entity<idaxOrganization>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.UserId,
                    e.UpdateGuid
                });
            modelBuilder.Entity<IDAX_ORGANIZATION>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.UserId,
                    e.UpdateGuid
                });
            modelBuilder.Entity<idaxTemplateDepartment>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.Department,
                    e.Asset,
                    e.Source,
                    e.Prefix,
                    e.Suffix,
                    e.UpdateGuid
                });
            modelBuilder.Entity<IDAX_TEMPLATE_DEPARTMENT>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.Department,
                    e.Asset,
                    e.Source,
                    //e.Prefix,
                    //e.Suffix,
                    e.UpdateGuid
                });
            modelBuilder.Entity<idaxTemplateRole>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.RoleDescription,
                    e.Asset,
                    e.Source,
                    e.Prefix,
                    e.Suffix,
                    e.UpdateGuid
                });
            modelBuilder.Entity<IDAX_TEMPLATE_ROLE>()
                .HasKey(e => new
                {
                    e.ScenarioId,
                    e.Role,
                    e.Asset,
                    e.Source,
                    //e.Prefix,
                    //e.Suffix,
                    e.UpdateGuid
                });
        }

        public DbSet<idaxScenarios> IdaxScenarios { get; set; }
        public DbSet<IDAX_SCENARIOS> IDAX_SCENARIOS { get; set; }
        public DbSet<idaxSettings> IdaxSettings { get; set; }
        public DbSet<IDAX_SETTINGS> IDAX_SETTINGS { get; set; }
        public DbSet<IDAX_ENTITLEMENTS> IDAX_ENTITLEMENTS { get; set; }
        public DbSet<idaxEntitlements> idaxEntitlements { get; set; }
        public DbSet<IDAX_ORGANIZATION> IDAX_ORGANIZATION { get; set; }
        public DbSet<idaxOrganization> idaxOrganizations { get; set; }
        public DbSet<idaxAssets> idaxAssets { get; set; }
        public DbSet<IDAX_ASSETS> IDAX_ASSETS { get; set; }
        public DbSet<idaxDuplicateAssets> idaxDuplicateAssets { get; set; }
        public DbSet<IDAX_DUPLICATE_ASSETS> IDAX_DUPLICATE_ASSETS { get; set; }
        public DbSet<idaxGroups> idaxGroups { get; set; }
        public DbSet<IDAX_GROUPS> IDAX_GROUPS { get; set; }
        public DbSet<idaxTemplateDepartment> idaxTemplateDepartment { get; set; }
        public DbSet<IDAX_TEMPLATE_DEPARTMENT> IDAX_TEMPLATE_DEPARTMENT { get; set; }
        public DbSet<idaxTemplateRole> idaxTemplateRole { get; set; }
        public DbSet<IDAX_TEMPLATE_ROLE> IDAX_TEMPLATE_ROLE { get; set; }
    }
}
