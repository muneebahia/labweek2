using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Application.DL;
using Application.UI;
namespace Application.BL
{
    class validations
    {
        public static void isLoadData()
        {
            bool check = UserDL.readdatafromfile();
            if (check)
            {
                headersUI.showMsg("Data lodedd successfully..........");
                headersUI.header();
            }
            else
            {
                headersUI.showMsg("Data Not loaded");
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

        /* if (!Regex.IsMatch(password, "[A-Z]"))
             return false;

         if (!Regex.IsMatch(password, "[a-z]"))
             return false;

         if (!Regex.IsMatch(password, "[0-9]"))
             return false;

         // All criteria met
         return true;*/


    }
}
