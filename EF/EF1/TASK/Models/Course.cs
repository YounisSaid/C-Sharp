using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Models
{
    //public class Course
    //{
    //    public int ID { get; set; }
    //    public int Duration { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public int Top_ID { get; set; } // Foreign Key 
    //}
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [Length(0,100)]
        public int Duration { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; } // Foreign Key 
    }
}
