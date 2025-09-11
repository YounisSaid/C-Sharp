using EF01.Contexts;
using EF01.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Entity FrameworkCore => ORM
            // ORM => Object Relational Mapper
            // DbContext , Entities

            // 2 Approaches
            // Database First
            // Code First

            // ADO.Net Vs Dapper (Mini ORM)
            #region Add
            using CompanyDbContext context = new CompanyDbContext();

            Employee employee = new Employee()
            {
                Name = "Younisddddddd",
                //Salary = 10,
                Address = "agg",
                Email = "Youn@gmail.com",
                test = 10

            };
            Console.WriteLine(context.Entry<Employee>(employee).State);
            Console.WriteLine(employee.Id);
            context.Add(employee);
            //context.Add<Employee>(employee);
            //context.Employees.Add(employee);
            //context.Set<Employee>().Add(employee);
            //context.Entry<Employee>(employee).State = EntityState.Added;

            Console.WriteLine(context.Entry<Employee>(employee).State);
            Console.WriteLine(employee.Id);

            context.SaveChanges();
            Console.WriteLine(context.Entry<Employee>(employee).State);
            Console.WriteLine(employee.Id);

            #endregion

            #region Retrive
            //var employee2 = context.Employees.FirstOrDefault(employee => employee.Id == 1);
            //var employee2 = context.Employees.AsNoTracking().FirstOrDefault(employee => employee.Id == 1);
            //Console.WriteLine(context.Entry<Employee>(employee).State);

            #endregion

            #region Update
            //var employee2 = context.Employees.FirstOrDefault(employee => employee.Id == 1);
            //if (employee2 != null)
            //{
            //    Console.WriteLine(context.Entry<Employee>(employee).State); // unchanged
            //    employee2.Name = "hhhhhhhh";
            //    Console.WriteLine(context.Entry<Employee>(employee).State); // modified
            //    context.SaveChanges();
            //    Console.WriteLine(context.Entry<Employee>(employee).State); // Unchanged

            //}

            #endregion

            #region Delete
            //var employee2 = context.Employees.FirstOrDefault(employee => employee.Id == 1);
            //if (employee2 != null)
            //{
            //    Console.WriteLine(context.Entry<Employee>(employee).State); // unchanged
            //    context.Remove(employee);
            //    //context.Remove<Employee>(employee);
            //    //context.Employees.Remove(employee);
            //    //context.Set<Employee>().Remove(employee);
            //    //context.Entry<Employee>(employee).State = EntityState.Deleted;
            //    Console.WriteLine(context.Entry<Employee>(employee).State); // deleted
            //    context.SaveChanges();
            //    Console.WriteLine(context.Entry<Employee>(employee).State); // detached

            //}
            #endregion


        }
    }
}
