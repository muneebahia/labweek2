using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using  Application.BL;
using Application.UI;
namespace Application.DL
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
       
        public static void storeDatainfile(  )
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < users.Count; i++)
            {
                file.WriteLine(users[i].Name + "," + users[i].Password + "," + users[i].getrole());
            }
            file.Flush();
            file.Close();
            
        }
        
        public static void storeDatainlist( User user)
        {
            users.Add(user);
        }
        public static bool readdatafromfile()
        {
            User user=null;
            if (File.Exists(path))
            {
                StreamReader variable = new StreamReader(path);
                string record;
                while ((record = variable.ReadLine()) != null)
                {
                    if (record == "" || record == " ")
                    {
                        continue;
                    }
                    string name = record.Split(',')[0];
                    string password = record.Split(',')[1];
                    string role = record.Split(',')[2];
                    // = new User();
                    if(role=="Admin")
                    {
                        user = new admin(name, password);
                    }
                    if(role=="Customer")
                    {
                        user = new customer(name, password);
                    }
                   // User user = new User(name, password, role);
                    storeDatainlist(user);
                }
                variable.Close();
                return true;
            }
            else
            {
                headersUI.showMsg("File Not Exists!!!");
            }
            return false;
            Console.ReadKey();
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
        public static bool ValidPassword(string name, string pass)
        {
            foreach (var i in users)
            {
                if (name == i.Name && pass == i.Password)
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}
