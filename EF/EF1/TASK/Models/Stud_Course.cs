using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Models
{
    public class Stud_Course
    {
        [Key]
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public string Grade { get; set; }
    }

    //public class Stud_Course
    //{
    //    [Key]
    //    [Required]
    //    public int Stud_ID { get; set; }
    //    [Key]
    //    [Required]
    //    public int Course_ID { get; set; }
    //    [Required]
    //    public string Grade { get; set; }
    //}
}
