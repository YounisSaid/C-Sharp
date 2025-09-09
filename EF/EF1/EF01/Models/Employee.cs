using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    ////By convection
    //public class Employee
    //{
    //    public int Id { get; set; } // public numeric ID or EmployeeID (PK+identity(1,1))
    //    public string?  Name { get; set; } // nvarchar(max)
    //}

    //By Data Annoation
    public class Employee
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        [Length(10, 200)]
        [Column(TypeName = "varchar")]

        public string Name { get; set; }

        [AllowedValues(10, 20, 30)]
        [DeniedValues(10, 020, 30)]
        [Range(10, 30)]
        [DefaultValue(null)]
        public decimal? Salary { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [NotMapped]
        public int test { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Address { get; set; }

    }

}