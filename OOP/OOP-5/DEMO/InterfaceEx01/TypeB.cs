using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.InterfaceEx01
{
    internal class TypeB : ISeries
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 2; // Increment by 2 for TypeB
            Console.WriteLine($"Current value is: {Current}");
        }
       
    }
   
}
