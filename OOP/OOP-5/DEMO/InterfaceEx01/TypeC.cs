using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.InterfaceEx01
{
    internal class TypeC : ISeries
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 3; // Increment by 3 for TypeC
            Console.WriteLine($"Current value is: {Current}");
        }
       
    }
   
}
