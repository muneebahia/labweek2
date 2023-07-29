using practice.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
//using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace practice.DL
{
    internal class UserDL
    {
        public static List<User> userList = new List<User>();
        public static string userFilePath = "users.txt";
       
        public static bool readData()
        {
           userList.Clear();
            if (File.Exists(userFilePath))
            {
                StreamReader fileVariable = new StreamReader(userFilePath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] fields = record.Split(',');
                    if (fields.Length <= 4)
                    {
                        string name = fields[0];
                        string password = fields[1];
                        string role = fields[2];
                        Customer obj;
                        User user_obj = null;
                        if (role == "Admin")
                        {
                            user_obj = new Admin(name, password);
                        }
                        else if (role == "Customer")
                        {
                            user_obj = new Customer(name, password);

                        }
                        storeDataInList(user_obj);
                       

                    }
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
        public static void reWriteFile()
        {
            StreamWriter file = new StreamWriter(userFilePath, false);
            foreach (var i in UserDL.userList)
            {
                file.WriteLine(i.Name + "," + i.Password + "," + i.getrole());
            }
            file.Flush();
            file.Close();
        }
        public static void storeDataInFile(User user_obj)
        {
            StreamWriter file = new StreamWriter(userFilePath, true);
            file.WriteLine(user_obj.Name + "," + user_obj.Password  + "," + user_obj.getrole());
            file.Flush();
            file.Close();
        }
        public static void storeDataInList(User user_obj)
        {
            userList.Add(user_obj);
        }

        public static User signInIfValid(User user_obj)
        {
            foreach (User storedUser in userList)
            {
                if (user_obj.Name == storedUser.Name && user_obj.Password == storedUser.Password)
                {
                    return storedUser;
                }
            }
            return null;
        }
    }
}
