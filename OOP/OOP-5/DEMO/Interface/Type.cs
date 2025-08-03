using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Interface
{
    internal class Type : IType
    {
        public int ID { get; set;  }

        public void Print()
        {
            Console.WriteLine($"ID");
        }
    }
}
