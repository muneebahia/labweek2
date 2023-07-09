using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdtask2_gridView
{
    class User
    {
        private string name;
        private string password;
        private string role;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public User(string name,string password,string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }

    }
}
