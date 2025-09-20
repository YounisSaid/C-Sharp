using EF01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int Serial { get; set; }

        public virtual ICollection<Employee> employees { get; set; }

    }
}
