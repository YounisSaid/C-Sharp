﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int Dept_ID { get; set; } // Foreign Key 
    }
}
