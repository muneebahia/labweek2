using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using task2.BL;
namespace task2.DL
{
    class UserDL
    {
        public static List<User> users = new List<User>();
        public static string path = "users.txt";
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }


                else if (comma == field)
                {
                    item = item + record[i];
                }

            }
            return item;

        }
        
        /* if (!Regex.IsMatch(password, "[A-Z]"))
             return false;

         if (!Regex.IsMatch(password, "[a-z]"))
             return false;

         if (!Regex.IsMatch(password, "[0-9]"))
             return false;

         // All criteria met
         return true;*/

        public static void storeDatainfile(User user,string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            for (int i = 0; i < users.Count; i++)
            {
                file.WriteLine(users[i].Name + "," + users[i].Password + "," + users[i].Role);

            }
            file.Flush();
            file.Close();

        }
        public static void storeDatainlist(User user)
        {
            users.Add(user);
        }
        public static bool readdatafromfile()
        {

            if (File.Exists(path))
            {
                StreamReader variable = new StreamReader(path);
                string record;
                while ((record = variable.ReadLine()) != null)
                {

                    string name = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);
                    User user = new User(name, password, role);
                    storeDatainlist(user);
                }
                variable.Close();
                return true;
            }
            return false;
        }

        public static User signin(User user)
        {
            foreach (User storedData in users)
            {
                if (user.Name == storedData.Name && user.Password == storedData.Password)
                {
                    return storedData;
                }
            }
            return null;
        }
        public static void updatePass(string name, string pass)
        {
            bool isupdatePassword = false;
            if (!isupdatePassword)
            {
                foreach (var i in users)
                {
                    if (name == i.Name && pass == i.Password)
                    {
                        //headersUI.showMsg("Enter new password");
                        string newpass = Console.ReadLine();
                        i.Password = newpass;
                    }
                }
            }
            else
            {
               // headersUI.showMsg("Enter correct old name and password.");
            }
        }
    }
}

