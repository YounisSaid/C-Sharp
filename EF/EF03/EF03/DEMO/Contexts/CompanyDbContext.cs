using DEMO.Models;
using EF01.Models;

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
                "server=.; database=CompanyDb003; trusted_connection=true; TrustServerCertificate=True;")
                          .UseLazyLoadingProxies();

         
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Course>()
            //            .HasMany(x => x.Students)
            //            .WithMany(x => x.Courses);

            modelBuilder.Entity<StudentCourse>().HasKey(x => new { x.StudentId, x.CourseId });

            modelBuilder.Entity<Department>().HasData(
                                                        new Department { DeptId = 1, DeptName = "Pr", DateOfCreation = DateTime.Now },
                                                        new Department { DeptId = 1, DeptName = "Pr", DateOfCreation = DateTime.Now },
                                                        new Department { DeptId = 1, DeptName = "Pr", DateOfCreation = DateTime.Now }

                                                     );
            base.OnModelCreating(modelBuilder);


        }
        public DbSet<Employee> Employees { get; set; } //table

        public DbSet<Student> Students { get; set; }
        public DbSet <Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
