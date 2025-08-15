using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
   public class Employee :IEquatable<Employee>
    {
        public Employee(string name, int id, int salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }

        public bool Equals(Employee? other)
        {
            if (other == null)
            {
                return false;
            }
            return Id == other.Id && Name == other.Name && Salary == other.Salary;
        }

        override public string ToString()
        {
            return $"Name: {Name}, Id: {Id}, Salary: {Salary}";
        }
        override public bool Equals(object? obj)
        {
            //if (obj is Employee other)
            //{
            //    return Id == other.Id && Name == other.Name && Salary == other.Salary;
            //}
            //return false;

            Employee? other = obj as Employee;
            if (other == null)
            {
                return false;
            }
            return Id == other.Id && Name == other.Name && Salary == other.Salary;
        }
    }
}
