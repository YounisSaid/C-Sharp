using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Models
{
    //public class Department
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public DateTime HiringDate { get; set; }
    //    public int Ins_ID { get; set; } // Foreign Key 
    //}

    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime HiringDate { get; set; }
        public int Ins_ID { get; set; } // Foreign Key 
    }
}
