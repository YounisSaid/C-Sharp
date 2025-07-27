using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal class TypeB : TypeA
    {
        public int Y { get; set; }
        public new void Message()
        {
            Console.WriteLine("Hello from TypeB!");
        }
        public override void Display()
        {
            Console.WriteLine($"Value of Y: {Y}");
        }
        
      
       
    }
}
