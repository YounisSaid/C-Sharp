using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Design and implement a Class for the employees in a
            //  company:
            //  Notes:
            //  ● Employee is identified by an ID, Name, security level, salary, hire
            //  date and Gender.
            //  ● We need to restrict the Gender field to be only M or F[Male or
            //  Female]
            //  ● Assign the following security privileges to the employee(guest,
            //  Developer, secretary and DBA) in a form of Enum.
            //  ● We want to provide the Employee Class to represent Employee
            //  data in a string Form(override ToString()), display employee
            //  salary in a currency format. [Use String.Format() Function].

            Employee emp1 = new Employee(1, "John", "Male", DateTime.Now, 50000, SecurityLevel.Developer);
            Console.WriteLine(emp1.ToString());

            //0.Develop a Class to represent the Hiring Date Data:
             //● Consisting of fields to hold the day, month and Years.
             HiringDate hiringDate = new HiringDate(15, 8, 2023);
            Console.WriteLine($"Hiring Date: {hiringDate.Day}/{hiringDate.Month}/{hiringDate.Year}");

            //3.0. Create an array of Employees with size three a DBA, Guest
            //and the third one is security officer who have full permissions.
            //(Employee[] EmpArr;)

            //Notes:
            //● Implement All the Necessary Member Functions on the
            //Class(Getters, Setters)
            //● Define all the Necessary Constructors for the Class
            //● Allow NO RUNTIME errors if the user inputs any data
            //● Write down all the necessary Properties(Instead of
            //setters and getters)
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Younis", "Male", DateTime.Parse("2021-05-10"), 10000m, SecurityLevel.DBA);
            EmpArr[1] = new Employee(2, "Sara", "Female", DateTime.Parse("2022-01-15"), 5000m, SecurityLevel.guest);
            EmpArr[2] = new Employee(3, "Said", "Male", DateTime.Today, 15000m, SecurityLevel.SecurityOfficer);

            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }


        }

    }
}
