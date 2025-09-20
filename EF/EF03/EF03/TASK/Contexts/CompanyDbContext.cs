//using EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Contexts
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() :base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=.; database=CompanyDb; trusted_connection=true; TrustServerCertificate=True;");
        }

        //public DbSet<Employee> Employees { get; set; } //table

    }
}
