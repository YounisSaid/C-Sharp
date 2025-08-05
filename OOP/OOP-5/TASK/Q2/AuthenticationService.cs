using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK.Q2
{
    internal class AuthenticationService : IAuthenticationService
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public void AuthenticateUser()
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                throw new ArgumentException("Username and password cannot be empty.");
            }
            if (UserName == "admin" && Password == "password123")
            {
                Console.WriteLine("User authenticated successfully.");
            }
            else
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }
        }

        public bool AuthorizeUser(string role)
        {

            if (UserName == "admin" && role == "Administrator")
            {
                Console.WriteLine("User is authorized.");
                return true;
            }
            else if (UserName == "user" && role == "User")
            {
                Console.WriteLine("User is authorized.");
                return true;
            }
            else
            {
                Console.WriteLine("User is not authorized.");
                return false;
            }
        }
        public AuthenticationService(string Username, string Password)
        {
           this.UserName = Username;
           this.Password = Password;
        }
    }
}
