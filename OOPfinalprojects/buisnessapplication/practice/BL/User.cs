using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.BL
{
    public class User
    {

        private string name;
        private string password;
        private string role;

        [DisplayName("Name")]
        public string Name { get => name; set => name = value; }
        [DisplayName("Password")]
        public string Password { get => password; set => password = value; }
        [DisplayName("Role")]
        public string Role { get => role; set => role = value; }

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
            
        }
        public User(string name, string password,string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public virtual string getrole()
        {
            return "null";
        }
        public virtual void showList() { }
    }
}
