using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Models
{
    public class Course_Inst
    {
        public int Course_InstID { get; set; }
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public string evaluate { get; set; }
    }

    //public class Course_Inst
    //{
    //    [Key]
    //    [Required]
    //    public int Inst_ID { get; set; }

    //    [Required]
    //    public int Course_ID { get; set; }
    //    public string evaluate { get; set; }
    //}
}
