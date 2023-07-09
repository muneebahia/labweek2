using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Application.BL;
using Application.UI;
namespace Application.DL
{
    class productDL
    {
        public static List<product> itemList = new List<product>();
        public static string path2 = "product.txt";
        public static void writeDataInFile()
        {
            StreamWriter file = new StreamWriter(path2, false);
            for (int i = 0; i < itemList.Count; i++)
            {
                file.WriteLine(itemList[i].MedicineName + "," + itemList[i].MedicinePrice+","+ itemList[i].Quantity);

            }
            file.Flush();
            file.Close();
        }
       
        public static bool checkName(string medName)
        { 
            foreach(var i in itemList)
            {
                if (medName == i.MedicineName)
                {
                    return true;
                }
            }
            return false;
        }
     
        public static void additemInList(product obj)
        {
            itemList.Add(obj);
        }
        public static void deleteMedFromList(/*product i*/string deletedMedicine)
        {
           
            foreach (var i in productDL.itemList.ToList())
            {
                if (deletedMedicine == i.MedicineName)
                {
                    itemList.Remove(i);
                    //  productDL.deleteMedFromList(i);
                }
            }
            Console.WriteLine("Item has deleted!");

        }
       public static void readproductdatafromfile()
        {

            if (File.Exists(path2))
            {
                StreamReader variable = new StreamReader(path2);
                string record;
                while ((record = variable.ReadLine()) != null)
                {
                    if (record == "" || record == " ")
                    {
                        continue;
                    }
                    string medicineName = record.Split(',')[0];
                    if (int.TryParse(record.Split(',')[1], out int price) && int.TryParse(record.Split(',')[2], out int stock))
                    {
                        product obj = new product(medicineName, price, stock);
                        itemList.Add(obj);
                    }
                    else
                    {
                        headersUI.showMsg("Enter Valid Input!!!!");
                    }
                }
                variable.Close();
            }
            else
            {
                headersUI.showMsg("File Not Exists!!!");
            }
            Console.ReadKey();
        }
    }
}
