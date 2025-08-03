using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.InterfaceEx02
{
    internal interface IMoveOnAir
    {
        public void Forward();
        public void Backward();
        public void Left();
        public void Right();
    }
}
