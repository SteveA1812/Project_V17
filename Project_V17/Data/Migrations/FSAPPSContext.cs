using Microsoft.EntityFrameworkCore;
using Project_V17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_V17.Data.Migrations
{
    public class FSAPPSContext :ApplicationDbContext
    {
        public FSAPPSContext(DbContextOptions<FSAPPSContext> options)
          : base(options)
        {
        }

        public DbSet<Project_V17.Models.FSApp> Applications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { modelBuilder.Entity<FSApp>().ToTable("StaffApplication"); }
    }
}

