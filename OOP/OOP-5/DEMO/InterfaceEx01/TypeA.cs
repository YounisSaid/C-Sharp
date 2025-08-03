using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.InterfaceEx01
{
    internal class TypeA : ISeries
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current++;
            Console.WriteLine($"Current value is: {Current}");
        }
        // Reset method is inherited from ISeries interface
    }
   
    
}
