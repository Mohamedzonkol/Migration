using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Migrations.Data.Config;
using Migrations.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrationss.Data
{
    public class AppDbcontext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Coobrate> Coobrates { get; set; }
        public DbSet<Individual> Individuals { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("AppString.json").Build();
            var conectionstring = config.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(conectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbcontext).Assembly);
        }
    }
}
