using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Inhertance
{
    internal class Child : Parent // ,Car // C# does not support multiple inheritance
    {
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public override int Product()
        {
            return X + Y + Z;
        }
       
    }
}
