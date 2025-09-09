using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Models
{
    //public class Student
    //{
       
    //    public int ID { get; set; }
    //    public string FName { get; set; }
    //    public string LName { get; set; }
    //    public string Address { get; set; }
    //    public int Age { get; set; }
    //    public int Dep_ID { get; set; } // Foreign Key 
    //}

    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Length(10,20)]
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        [Required]
        public int Dep_ID { get; set; } // Foreign Key 
    }


}
