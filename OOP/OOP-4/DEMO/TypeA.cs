using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal class TypeA
    {
        public int X { get; set; }
        public void Message()
        {
            Console.WriteLine("Hello from TypeA!");
        }
        public virtual void Display()
        {
            Console.WriteLine($"Value of X: {X}");
        }
    }
}
