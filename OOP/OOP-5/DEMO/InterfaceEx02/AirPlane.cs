using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.InterfaceEx02
{
    internal class AirPlane : Vehicle, IMoveOnGround, IMoveOnAir
    {
        void IMoveOnGround.Backward()
        {
            throw new NotImplementedException();
        }

        void IMoveOnAir.Backward()
        {
            throw new NotImplementedException();
        }

        void IMoveOnGround.Forward()
        {
            throw new NotImplementedException();
        }

        void IMoveOnAir.Forward()
        {
            throw new NotImplementedException();
        }

        void IMoveOnGround.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveOnAir.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveOnGround.Right()
        {
            throw new NotImplementedException();
        }

        void IMoveOnAir.Right()
        {
            throw new NotImplementedException();
        }
    }
}
