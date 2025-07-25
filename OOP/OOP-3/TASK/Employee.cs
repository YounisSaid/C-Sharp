using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    public enum SecurityLevel
    {
        guest,
        Developer,
        secretary , 
        DBA ,
        SecurityOfficer // Full permissions
    }
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private string _gender;

        public Employee(int iD, string name, string gender, DateTime hireDate, decimal salary, SecurityLevel security)
        {
            ID = iD;
            Name = name;
            Gender = gender;   
            HireDate = hireDate;
            Salary = salary;
            Security = security;
        }

        public string Gender
        {
            get => _gender;
            set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new ArgumentException("Gender must be 'Male' or 'Female'");
                }
                _gender = value;
            }
        }


        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public SecurityLevel Security { get; set; }
        
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Salary: {2:C}", ID, Name, Salary);
        }
    }
}
