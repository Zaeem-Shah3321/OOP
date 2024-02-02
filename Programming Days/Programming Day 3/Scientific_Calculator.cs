using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            start:
            string option = menu();
            if (option == "1")
            {
                calculator c1 = new calculator();
                while (true)
                {
                    option = menu();
                    if (option == "2")
                    {
                        getnumber(ref c1.number1);
                    }
                    if (option == "3")
                    {
                        Console.Write(c1.sq_rt());
                    }
                    if (option == "4")
                    {
                        Console.Write(c1.exponential());
                    }
                    if (option == "5")
                    {
                        Console.Write(c1.log());
                    }
                    if (option == "6")
                    {
                        string type;
                        Console.Write("Write Type (sin,cos,tan): ");
                        type = Console.ReadLine();
                        Console.Write(c1.trig(type));
                    }
                    if (option == "7")
                    {
                        return;
                    }
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Enter 1 to Start");
                Console.ReadKey();
                goto start;
            }
        }
        static string menu()
        {
            string opt = "";
            Console.Clear();
            Console.WriteLine("1.Create the a Single Object of Calculator");
            Console.WriteLine("2.Change Value");
            Console.WriteLine("3.Square Root");
            Console.WriteLine("4.Exponential");
            Console.WriteLine("5.Logarithm");
            Console.WriteLine("6.Trignometric");
            Console.WriteLine("7.Exit");
            Console.Write("Enter Your Option: ");
            opt = Console.ReadLine();
            return opt;
        }
        static void getnumber(ref double num1)
        {
            Console.Write("Enter First Number: ");
            num1 = int.Parse(Console.ReadLine());
        }
    }
}
