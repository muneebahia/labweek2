using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using task2.DL;

namespace task2.BL
{
    class validations
    {
        public static void isLoadData()
        {
            bool check = UserDL.readdatafromfile(UserDL.path, UserDL.users);
            if (check)
            {
              //  headersUI.showMsg("Data lodedd successfully");
            }
            else
            {
               // headersUI.showMsg("Not loaded");
            }
        }
        public static bool validName(string name)
        {
            if (name.Length < 3)
            {
                return false;
            }
            return true;
        }

        public static bool validlengthPassword(string password)
        {

            if (password.Length < 8)
            {
                return false;
            }
            return true;

        }

        public static bool validspecialPassword(string password)
        {

            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            {
                return false;
            }

            return true;
        }
        public static bool validletterPassword(string password)
        {

            if (!Regex.IsMatch(password, "[a-z]"))
            {
                return false;
            }

            return true;
        }

    }
}
