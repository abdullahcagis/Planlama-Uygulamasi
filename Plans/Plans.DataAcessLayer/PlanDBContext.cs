using Microsoft.EntityFrameworkCore;
using Plan.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Timings;


namespace Plans.DataAcessLayer
{
    public class PlanDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-MH1I39NR\\SQLEXPRESS; Database=Plans_DB;integrated security=True");
        }
        public DbSet<Timing> timings { get; set; }

        public DbSet<Planss> plansss { get; set; }
    }
}
