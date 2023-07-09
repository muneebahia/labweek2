using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BL
{
    public class User
    {
        private string name;
        private string password;
        public virtual string getrole()
        {
            return "null";
        }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
       
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
       public User()
        { }
       

    }
}

