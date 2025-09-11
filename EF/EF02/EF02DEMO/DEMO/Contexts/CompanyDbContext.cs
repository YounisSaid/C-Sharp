using DEMO.Models;
using EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace EF01.Contexts
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=.; database=CompanyDb; trusted_connection=true; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Department>().HasKey(x=>x.DeptId);

            ////modelBuilder.Entity<Department>().Property(x => x.DeptId).UseIdentityColumn(10, 10)
            ////                                                           .IsRequired(true)

            ////                                 //.ValueGeneratedNever()
            ////                                 .HasDefaultValueSql("new Guid()");

            // //modelBuilder.Entity<Department>().Property(x => x.DeptId).HasColumnType("varchar")
            // //                                                          .HasMaxLength(100)
            // //                                                          .HasColumnName("DeptIDD")
            // //                                                          .IsRequired(false)
            // //                                                          .HasDefaultValue("Hr");

            //modelBuilder.Entity<Department>().Property(x => x.DateOfCreation).HasAnnotation("Datatype", "Date");
            //modelBuilder.Entity<Department>().Property(x => x.DateOfCreation).HasDefaultValue("GetDate()");

            //modelBuilder.Entity<Department>().Ignore(x => x.Serial);

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<User>()
                        .HasOne(x => x.UserProfile)
                        .WithOne(x => x.User)
                        .HasForeignKey<UserProfile>("UserID");

            modelBuilder.Entity<Catageory>()
                .HasMany(x => x.Proudcts)
                .WithOne(x => x.Catageory);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; } //table
        public DbSet<Department> Departments { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Proudct> Proudcts { get; set; }
        public DbSet<Catageory> Catageories { get; set; }
    }
}