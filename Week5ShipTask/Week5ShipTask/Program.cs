using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5ShipTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ship> ships = new List<ship>();
            ship shipobj = null;
            int choice;
            do
            {
                choice = Menu();
                if(choice==1)
                {
                    shipobj = addShip();
                    addShipInList(shipobj, ships);
                }
                if(choice==2)
                {
                    string serialNo=shipposition();
                    angle latitude = shipobj.returnLocationLatitude(ships, serialNo);
                    angle longitude = shipobj.returnLocationLongitude(ships, serialNo);
                    position(latitude, longitude);
                    
                }
                if (choice == 3)
                {
                    angle longitude = takeinpForLongitude();
                    angle latitude = takeinpForLatitudee();
                    string serialNo=shipobj.returnSerialNo(longitude, latitude, ships);
                    viewSerialNo(serialNo);
                }
                if(choice==4)
                {
                    ship shipnewobj = takeinputforChangingposition();
                    printShipsNewPosition(ships, shipnewobj);
                }
            } while (choice<5);
        }
        static int Menu()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("        Ocean Nevigation System              ");
            Console.WriteLine("*********************************************");
            Console.WriteLine("1. Add ship");
            Console.WriteLine("2. View ship position");
            Console.WriteLine("3. view ship serial no ");
            Console.WriteLine("4. change ship position");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter Your Choice:");
            int choice = int.Parse(Console.ReadLine());
            return choice;

        }
        static ship addShip()
        {
            Console.WriteLine("Enter the ship no:");
            string ShipNo = Console.ReadLine();

            Console.WriteLine("Enter Ship Longitude:");
            Console.WriteLine("Enter Longitude Degree:");
            int lDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Longitude Min:");
            float lMin = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Longitude Direction:");
            char lDirection = char.Parse(Console.ReadLine());
            angle longitude = new angle(lDegree, lMin, lDirection);

            Console.WriteLine("Enter Ship Latitude:");
            Console.WriteLine("Enter Latitude Degree:");
            int Degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Latitude Min:");
            float Min =float.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Latitude Direction:");
            char Direction = char.Parse(Console.ReadLine());
            angle latitude = new angle(Degree, Min, Direction);

            ship ship = new ship(ShipNo, latitude, longitude);
            return ship;
        }
        static void addShipInList(ship obj,List<ship> ships)
        {
            ships.Add(obj);
        }
        static string shipposition()
        {
            Console.WriteLine("Enter ship Serial Number to find its position:");
            string SerialNo = Console.ReadLine();
            return SerialNo;
        }
        static void position(angle latitude, angle longitude)
        {
            Console.WriteLine("latitude:");
            Console.WriteLine(latitude.Degree+ " " + latitude.Min+ " " + latitude.Direction);
            Console.WriteLine("longitude:");
            Console.WriteLine(longitude.Degree + " " + longitude.Min + " " + longitude.Direction);
        }
        static angle takeinpForLongitude()
        {
            Console.WriteLine("Enter Longitude Degree:");
            int lDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Longitude Min:");
            float lMin = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Longitude Degree:");
            char lDirection = char.Parse(Console.ReadLine());
            angle longitude = new angle(lDegree, lMin, lDirection);
            return longitude;
        }
        static angle takeinpForLatitudee()
        {
            Console.WriteLine("Enter Latitude Degree:");
            int Degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Latitude Min:");
            float Min = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Latitude Direction:");
            char Direction = char.Parse(Console.ReadLine());
            angle latitude = new angle(Degree, Min, Direction);
            return latitude;

        }
        static void viewSerialNo(string serialNo)
        {
            Console.WriteLine("The SerialNo of the Ship is{0}:", serialNo);
        }
        static ship takeinputforChangingposition()
        {
            Console.WriteLine("Enter the ship no whose position you want to change:");
            string ShipNo = Console.ReadLine();

            Console.WriteLine("Enter Ship's new Latitude:");
            Console.WriteLine("Enter Latitude Degree:");
            int Degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Latitude Min:");
            float Min = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Latitude Direction:");
            char Direction = char.Parse(Console.ReadLine());
            angle latitude = new angle(Degree, Min, Direction);

            Console.WriteLine("Enter Ship's new Longitude:");
            Console.WriteLine(" ");
            Console.WriteLine("Enter Longitude Degree:");
            int lDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Longitude Min:");
            float lMin = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter  Longitude Degree:");
            char lDirection = char.Parse(Console.ReadLine());
            angle longitude = new angle(lDegree, lMin, lDirection);
            ship newshipObj = new ship(ShipNo, latitude, longitude);
            return newshipObj;


        }
       static void printShipsNewPosition(List<ship>ships, ship shipnewobj)
        {
            foreach(ship x in ships)
            {
                if(x.serialNo== shipnewobj.serialNo)
                {
                    x.latitude.Degree = shipnewobj.latitude.Degree;
                    x.latitude.Min = shipnewobj.latitude.Min;
                    x.latitude.Direction = shipnewobj.latitude.Direction;
                    x.longitude.Degree = shipnewobj.longitude.Degree;
                    x.longitude.Min = shipnewobj.longitude.Min;
                    x.longitude.Direction = shipnewobj.longitude.Direction;
                    Console.WriteLine("ship latitude at new position:" + x.latitude.Degree + " " + x.latitude.Min + " " + x.latitude.Direction) ;
                    Console.WriteLine("ship longitude at new position:" + x.longitude.Degree + " " + x.longitude.Min + " " + x.longitude.Direction);
                }
            }
        }
    }
}
