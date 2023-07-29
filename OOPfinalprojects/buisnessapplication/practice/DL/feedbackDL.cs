using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice.BL;
using System.Xml.Linq;

namespace practice.DL
{
    internal class feedbackDL
    {
        public static List<feedback> feedbacklist = new List<feedback>();
        public static string path3 = "feedback.txt";
        public static void writeDataInFile()
        {
            StreamWriter file = new StreamWriter(path3, false);
            for (int i = 0; i < feedbacklist.Count; i++)
            {
                file.WriteLine( feedbacklist[i].Username + "," + feedbacklist[i].GoodProduct + "," + feedbacklist[i].FeedBack );

            }
            file.Flush();
            file.Close();
        }



        public static void additemInList(feedback obj)
        {
            feedbacklist.Add(obj);
        }

        public static void readfeedbackdatafromfile()
        {

            if (File.Exists(path3))
            {
                StreamReader variable = new StreamReader(path3);
                string record;
                while ((record = variable.ReadLine()) != null)
                {
                    if (record == "" || record == " ")
                    {
                        continue;
                    }
                    string name = record.Split(',')[0];
                    string bestproduct = record.Split(',')[1];
                    string feedBack = record.Split(',')[2];

                    feedback obj = new feedback(name,bestproduct, feedBack);
                    feedbacklist.Add(obj);
                }
                variable.Close();
            }
            else
            {
                MessageBox.Show("File Not Exists!!");
            }
        }
    }
}