using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entities.Concrete.EntityFramework
{
    public class EnergyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Data Source=DESKTOP-M1MR0GD\MSSQLSERVER2022;Initial Catalog=Energy;Integrated Security=True;Persist Security Info=False;TrustServerCertificate=true");
        }
        public DbSet<Productivity> Productivities { get; set; }
        public DbSet<EnergyEfficiencyChange> EnergyEfficiencies { get; set; }
    }
}