using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal class UserView
    {
        public int Id { get; set; }
        public string FirsrName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public static explicit operator UserView(User user)
        {
            if (user == null)
                return null;
            return new UserView
            {
                Id = user.Id,
                FirsrName = user.Name.Split(' ')[0],
                LastName = user.Name.Split(' ').Length > 1 ? user.Name.Split(' ')[1] : string.Empty,
                Email = user.Email,
                Phone = user.Phone,
                Address = user.Address
            };
        }
    }
}
