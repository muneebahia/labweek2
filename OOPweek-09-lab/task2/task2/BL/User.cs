using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class User
    {
        private string name;
        private string password;
        private string role;
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public User(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public bool isAdmin()
        {
            if (role == "Admin" || role == "admin")
            {
                return true;
            }
            return false;
        }

    }
}


