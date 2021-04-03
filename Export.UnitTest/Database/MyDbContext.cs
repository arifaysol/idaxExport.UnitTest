using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base()
        {

        }

        public DbSet<idaxScenarios> IdaxScenarios { get; set; }
        public DbSet<IDAX_SCENARIOS> IDAX_SCENARIOS { get; set; }
        public DbSet<idaxSettings> IdaxSettings { get; set; }
        public DbSet<IDAX_SETTINGS> IDAX_SETTINGS { get; set; }
    }
}
