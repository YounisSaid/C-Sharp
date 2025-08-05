using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Q1
{
    internal class Rectangle : IRectangle
    {
        public int Width { get; set; }
        public int Height { get; set ; }

        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
           Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area}");
        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
