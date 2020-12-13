using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Date
{
    public class HeroContext : DbContext
    {
        public DbSet<Hero> Heros { get; set; }
        public DbSet<Batle> Batles { get; set; }
        public DbSet<Arm> Arms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=HeroApp;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
