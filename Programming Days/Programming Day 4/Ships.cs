using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    internal class Program
    {
        public static List<Ships> Sh = new List<Ships>();
        static void Main(string[] args)
        {
            
            while (true)
            {
                int option = menu();
                if (option == 1)
                {
                    addShip();
                }
                else if (option == 2)
                {
                    viewShipPosition();
                }
                else if (option == 3)
                {
                    viewShipSerialNumber();
                }
                else if (option == 4)
                {
                    changeShipPosition();
                }
                else if (option == 5)
                {
                    return;
                }
                Console.ReadKey();

            }
        }
        static int menu()
        {
            int opt = 0;
            Console.Clear();
            Console.WriteLine("----Menu----");
            Console.WriteLine("1. Add Ship");
            Console.WriteLine("2. View Ship Position");
            Console.WriteLine("3. View Ship Serial Number");
            Console.WriteLine("4. Change Ship Position");
            Console.WriteLine("5. Exit");
            opt = int.Parse(Console.ReadLine());
            return opt;
        }
        static void addShip()
        {
            Console.Clear();
            Console.WriteLine("----Add Ship----");
            Console.Write("Enter Serial Number: ");
            string serial = Console.ReadLine();
            Console.WriteLine("Enter Latitude: ");
            Console.Write("Enter Latitude’s Degree: ");
            int latdeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Minute: ");
            float latmin = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Direction: ");
            char latdir = char.Parse(Console.ReadLine());
            Angle lat = new Angle(latdeg, latmin, latdir);



            Console.WriteLine("Enter Longitude: ");
            Console.Write("Enter Longitude’s Degree: ");
            int londeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Minute: ");
            float lonmin = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Direction: ");
            char londir = char.Parse(Console.ReadLine());
            Angle lon = new Angle(londeg, lonmin, londir);


            Ships ship = new Ships(serial, lat, lon);
            Sh.Add(ship);





        }
        static void viewShipPosition()
        {
            Console.Clear();
            Console.WriteLine("----View Ship Position----");
            Console.Write("Enter Serial Number: ");
            string serial = Console.ReadLine();
            foreach(Ships ship in Sh)
            {
                if (ship.serialNumber == serial)
                {
                    Console.WriteLine("Latitude: " + ship.latitude.location());
                    Console.WriteLine("Longitude: " + ship.longitude.location());
                }
            }
        }
        static void changeShipPosition()
        {
            Console.Clear();
            Console.WriteLine("----Change Ship Position----");
            Console.Write("Enter Serial Number: ");
            string serial = Console.ReadLine();
            foreach (Ships ship in Sh)
            {
                if (ship.serialNumber == serial)
                {
                    Console.WriteLine("Enter Latitude: ");
                    Console.Write("Enter Latitude’s Degree: ");
                    int latdeg = int.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude’s Minute: ");
                    float latmin = float.Parse(Console.ReadLine());
                    Console.Write("Enter Latitude’s Direction: ");
                    char latdir = char.Parse(Console.ReadLine());
                    ship.latitude = new Angle(latdeg, latmin, latdir);

                    Console.WriteLine("Enter Longitude: ");
                    Console.Write("Enter Longitude’s Degree: ");
                    int londeg = int.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude’s Minute: ");
                    float lonmin = float.Parse(Console.ReadLine());
                    Console.Write("Enter Longitude’s Direction: ");
                    char londir = char.Parse(Console.ReadLine());
                    ship.longitude = new Angle(londeg, lonmin, londir);
                }
            }
        }
        static void viewShipSerialNumber()
        {
            Console.Clear();
            Console.WriteLine("----View Ship Serial Number----");
            Console.WriteLine("----Latitude----");
            Console.Write("Enter Latitude’s Degree: ");
            int latdeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Minute: ");
            float latmin = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Direction: ");
            char latdir = char.Parse(Console.ReadLine());


            Console.WriteLine("----Longitude----");
            Console.Write("Enter Longitude’s Degree: ");
            int londeg = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Minute: ");
            float lonmin = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Direction: ");
            char londir = char.Parse(Console.ReadLine());

            foreach (Ships ship in Sh)
            {
                if ((ship.latitude.degrees == latdeg && ship.latitude.minutes == latmin && ship.latitude.direction == latdir) && (ship.longitude.degrees == londeg && ship.longitude.minutes == lonmin && ship.longitude.direction == londir))
                {
                    Console.WriteLine("Serial Number: " + ship.serialNumber);
                }
            }
        }
    }
}
