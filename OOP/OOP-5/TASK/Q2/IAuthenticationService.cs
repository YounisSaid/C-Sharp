using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Q2
{
    internal interface IAuthenticationService
    {
        void AuthenticateUser();
        bool AuthorizeUser(string role);
    }
}
