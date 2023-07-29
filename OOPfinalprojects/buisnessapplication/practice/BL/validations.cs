using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using practice.DL;

namespace practice.BL
{
    class validations
    {
      
        public static bool isUserUnique(string name)
        {
            foreach (var i in UserDL.userList)
            {
                if (name == i.Name)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool isPasswordValid(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            return true;
        }
        public static bool ValidPassword(string name, string pass)
        {
            foreach (var i in UserDL.userList)
            {
                if (name == i.Name && pass == i.Password)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool validName(string name)
        {
            if (name.Length < 3)
            {
                return true;
            }
            return false;
        }
       
        public static bool validnameExist(string name)
        {
            foreach(var i in productDL.itemList)
            {
                 if(name==i.MedicineName)
                 {
                    return true;
                 }
            }
            return false;
        }

        public static bool validspecialPassword(string password)
        {

            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            {
                return false;
            }

            return true;
        }
    }
}
