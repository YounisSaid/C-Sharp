using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Q1
{
    internal class Circle :ICircle
    {
        public int Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
        }
        public Circle(int radius)
        {
            Radius = radius;
        }
    }
    
}
