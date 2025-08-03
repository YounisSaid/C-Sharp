using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Interface
{
    internal interface IType
    {
        public int ID  { get; set; }
        public void Print();

        // default implemented Method
        public void PrintMessage()
        {
            Console.WriteLine("Hello from IType interface!");
        }
    }
}
