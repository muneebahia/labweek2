using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace crudwithconstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            header();
           
            string path2 = "users.txt";
            List<Muser> itemList = new List<Muser>();
            readdatafromfile(path2, itemList);
            Console.WriteLine("press any key to continue:");
           
            int choice;


            do
            {
                choice = takechoice();


                if (choice == 1)
                {

                    showlist(path2, itemList);
                    

                }
                else if (choice == 2)
                {

                    add_medicine(path2, itemList);
                    

                }
                else if (choice == 3)
                {

                    delete_medicine(path2, itemList);
                   

                }
                else if (choice == 4)
                {
                    update_stock(path2, itemList);
                   
                }
                //choice = takechoice();
            } while (choice< 5);
            Console.ReadKey();

        }
        static int takechoice()
        {
            int choice;
            Console.WriteLine("1. Check list");
            Console.WriteLine("2. Add the medicine");
            Console.WriteLine("3. Delete medicine");
            Console.WriteLine("4. Update list ");
            Console.WriteLine("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void add_medicine(string path2, List<Muser> itemList)
        {
            Console.Clear();
            addheader();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            string length;
            int length2;

            Console.WriteLine("enter numberr of the Medicin you want to add :");
            length = Console.ReadLine();
            length2 = int.Parse(length);

            for (int i = 0; i < length2; i++)
            {

                Console.WriteLine("enter the name of the Medicin you want to add :");
                string medicineName = Console.ReadLine();
                Console.WriteLine("enter the price of that medicine :");
                int price = int.Parse(Console.ReadLine());

                Console.WriteLine("enter the stock of that medicine :");
                int stock = int.Parse(Console.ReadLine());
                Muser obj = new Muser(medicineName, price, stock);
                itemList.Add(obj);
                //Console.WriteLine("n: {0} p:{1} s:{2}", obj.medicineName, obj.medicinePrice, obj.stock);


            }

            writeDataInFile(path2, itemList);
            Console.Write("Press any key to continue:");
            Console.ReadKey();
        }
        static void showlist(string path2, List<Muser> itemList)
        {
            Console.Clear();
            listheader();
            Console.Write(" ");
            Console.Write(" ");
            Console.Write(" ");
            Console.WriteLine(" Sr.No \t Medicine Name \t Price \t Stock");

            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine(i + 1 + "\t" + itemList[i].medicineName + "\t" + itemList[i].medicinePrice + "\t" + itemList[i].stock);
            }
            Console.WriteLine("press any key to continue:");
            Console.ReadKey();
        }
        static void delete_medicine(string path2, List<Muser> itemList)
        {
            Console.Clear();
            deleteheader();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            string deletedMedicine;

            Console.WriteLine("enter the name of the product you want to delete :");
            deletedMedicine = Console.ReadLine();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (deletedMedicine == itemList[i].medicineName)
                {
                    for (int j = i; j < itemList.Count; j++)
                    {
                        itemList.RemoveAt(i);
                       
                    }
                    
                }
            }
            Console.WriteLine("Item has deleted!");
            Console.Write("press any key to continue:");
            Console.ReadKey();
            writeDataInFile(path2, itemList);
        }
        static void update_stock(string path2, List<Muser> itemList)
        {
            Console.Clear();
            updateheader();
            Console.Write(" ");
            Console.Write(" ");
            Console.Write(" ");

            string medicine_name;
            Console.WriteLine("enter the name of the medicine whose price and stock you want to update:");
            medicine_name = Console.ReadLine();

            int new_stock;
            Console.WriteLine("enter the new stock of selected medicine:");
            new_stock = int.Parse(Console.ReadLine());

            int new_price;
            Console.WriteLine("enter the new price of medicine:");
            new_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Medicine Name \t Price \t Stock");


            for (int i = 0; i < itemList.Count; i++)
            {
                if (medicine_name == itemList[i].medicineName)
                {
                    itemList[i].stock = new_stock;
                    itemList[i].medicinePrice = new_price;

                    Console.WriteLine(itemList[i].medicineName + "\t" + itemList[i].medicinePrice + "\t" + itemList[i].stock);
                }
            }

            writeDataInFile(path2, itemList);
            Console.Write("press any key to continue:");
            Console.ReadKey();
        }

        static string parseData(string record, int field)
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
        static void writeDataInFile(string path2, List<Muser> itemList)
        {
            StreamWriter file = new StreamWriter(path2, false);
            for (int i = 0; i < itemList.Count; i++)
            {
                file.WriteLine(itemList[i].medicineName + "," + itemList[i].medicinePrice + "," + itemList[i].stock);

            }
            file.Flush();
            file.Close();
        }

        static void readdatafromfile(string path2, List<Muser> itemList)
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
                    string medicineName = parseData(record, 1);
                    int price = int.Parse(parseData(record, 2));
                    int newstock = int.Parse(parseData(record, 3));
                    Muser obj = new Muser(medicineName, price, newstock);


                   /* obj.medicineName = medicineName;
                    obj.medicinePrice = price;
                    obj.stock = newstock;*/
                    itemList.Add(obj);
                }
                variable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
            Console.ReadKey();
        }
        static void header()
        {
            Console.WriteLine("                           d8b   d8,                  d8b                                                 ");
            Console.WriteLine("                           88P  `8P                   88P                    d8P                          ");
            Console.WriteLine("                          d88                        d88                  d888888P                        ");
            Console.WriteLine("  88bd8b,d88b  d8888b d888888    88b d8888b d888b8b  888           .d888b,  ?88'   d8888b   88bd88b d8888b");
            Console.WriteLine("  88P'`?8P'?8bd8b_,dPd8P' ?88    88Pd8P' `Pd8P' ?88  ?88           ?8b,     88P   d8P' ?88  88P'  `d8b_,dP");
            Console.WriteLine(" d88  d88  88P88b    88b  ,88b  d88 88b    88b  ,88b  88b            `?8b   88b   88b  d88 d88     88b    ");
            Console.WriteLine("d88' d88'  88b`?888P'`?88P'`88bd88' `?888P'`?88P'`88b  88b        `?888P'   `?8b  `?8888P'd88'     `?888P'");
        }
        static void listheader()
        {
            Console.WriteLine(" @@@@@@@@@@  @@@@@@@@ @@@@@@@  @@@  @@@@@@@ @@@ @@@  @@@ @@@@@@@@      @@@      @@@  @@@@@@ @@@@@@@");
            Console.WriteLine(" @@! @@! @@! @@!      @@!  @@@ @@! !@@      @@! @@!@!@@@ @@!           @@!      @@! !@@       @@!  ");
            Console.WriteLine(" @!! !!@ @!@ @!!!:!   @!@  !@! !!@ !@!      !!@ @!@@!!@! @!!!:!        @!!      !!@  !@@!!    @!!  ");
            Console.WriteLine(" !!:     !!: !!:      !!:  !!! !!: :!!      !!: !!:  !!! !!:           !!:      !!:     !:!   !!:  ");
            Console.WriteLine("  :      :   : :: ::: :: :  :  :    :: :: : :   ::    :  : :: :::      : ::.: : :   ::.: :     :   ");
        }

        static void deleteheader()
        {
            Console.WriteLine(" @@@@@@@  @@@@@@@@ @@@      @@@@@@@@ @@@@@@@ @@@@@@@@      @@@@@@@@@@  @@@@@@@@ @@@@@@@  @@@  @@@@@@@ @@@ @@@  @@@ @@@@@@@@");
            Console.WriteLine(" @@!  @@@ @@!      @@!      @@!        @@!   @@!           @@! @@! @@! @@!      @@!  @@@ @@! !@@      @@! @@!@!@@@ @@!     ");
            Console.WriteLine(" @!@  !@! @!!!:!   @!!      @!!!:!     @!!   @!!!:!        @!! !!@ @!@ @!!!:!   @!@  !@! !!@ !@!      !!@ @!@@!!@! @!!!:!  ");
            Console.WriteLine(" !!:  !!! !!:      !!:      !!:        !!:   !!:           !!:     !!: !!:      !!:  !!! !!: :!!      !!: !!:  !!! !!:     ");
            Console.WriteLine(" :: :  :  : :: ::: : ::.: : : :: :::    :    : :: :::       :      :   : :: ::: :: :  :  :    :: :: : :   ::    :  : :: :::");
        }
        static void updateheader()
        {

            Console.WriteLine(" @@@  @@@ @@@@@@@  @@@@@@@   @@@@@@  @@@@@@@ @@@@@@@@");
            Console.WriteLine(" @@!  @@@ @@!  @@@ @@!  @@@ @@!  @@@   @@!   @@!     ");
            Console.WriteLine(" @!@  !@! @!@@!@!  @!@  !@! @!@!@!@!   @!!   @!!!:!  ");
            Console.WriteLine(" !!:  !!! !!:      !!:  !!! !!:  !!!   !!:   !!:     ");
            Console.WriteLine("  :.:: :   :       :: :  :   :   : :    :    : :: :::");
        }
        static void addheader()
        {
            Console.WriteLine("            @@@@@@  @@@@@@@  @@@@@@@ ");
            Console.WriteLine("           @@!  @@@ @@!  @@@ @@!  @@@");
            Console.WriteLine("           @!@!@!@! @!@  !@! @!@  !@!");
            Console.WriteLine("           !!:  !!! !!:  !!! !!:  !!!");
            Console.WriteLine("            :   : : :: :  :  :: :  : ");

        }




    }
}
