using DEMO.Models;
using EF01.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext companyDb = new CompanyDbContext();
            //companyDb.AddRange(new Department { DeptId = 1, DeptName = "Pr", DateOfCreation = DateTime.Now },
            //                                            new Department { DeptId = 1, DeptName = "Pr", DateOfCreation = DateTime.Now },
            //                                            new Department { DeptId = 1, DeptName = "Pr", DateOfCreation = DateTime.Now });
            //var employee = companyDb.Employees.First();
            //if(employee != null)
            //{
            //    Console.WriteLine(employee.Department?.DeptName);
            //}
            //var employee = companyDb.Employees.Include(x=>x.Department).ThenInclude(x=>x.employees).First();
            //companyDb.Entry(employee).Reference(x=>x.Department).Load();
            //var employee = companyDb.Employees.First(x=>x.DepartmentId ==1);
            //Console.WriteLine(employee.Department.DeptName);    

            var employee = from Employee in companyDb.Employees
                           join Department in companyDb.Departments
                           on Employee.DepartmentId equals Department.DeptId
                           select Employee;

            var result = companyDb.Employees.Join(companyDb.Departments, employee => employee.DepartmentId, Department => Department.DeptId, (employee, Department) => new
            { });


        }

    }
}
