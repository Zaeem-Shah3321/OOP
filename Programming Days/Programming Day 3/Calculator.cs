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
                        getnumber(ref c1.number1, ref c1.number2);
                    }
                    if (option == "3")
                    {
                        Console.Write(c1.add(c1.number1, c1.number2));
                    }
                    if (option == "4")
                    {
                        Console.Write(c1.subtract(c1.number1, c1.number2));
                    }
                    if (option == "5")
                    {
                        Console.Write(c1.multiply(c1.number1, c1.number2));
                    }
                    if (option == "6")
                    {
                        try
                        { 
                            Console.Write(c1.divide(c1.number1, c1.number2));
                        }
                        catch(DivideByZeroException) 
                        {
                            Console.Write("Can not divide by zero");
                        }
                    }
                    if (option == "7")
                    {
                        try
                        {
                            Console.Write(c1.mod(c1.number1, c1.number2));
                        }
                        catch (DivideByZeroException)
                        {
                            Console.Write("Can not take mod with zero");
                        }
                    }
                    if (option == "8")
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
            Console.WriteLine("2.Change Values of Attributes");
            Console.WriteLine("3.Add");
            Console.WriteLine("4.Subtract");
            Console.WriteLine("5.Multiply");
            Console.WriteLine("6.Divide");
            Console.WriteLine("7.Modulo");
            Console.WriteLine("8.Exit");
            Console.Write("Enter Your Option: ");
            opt = Console.ReadLine();
            return opt;
        }
        static void getnumber(ref int num1 , ref int num2)
        {
            Console.Write("Enter First Number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = int.Parse(Console.ReadLine());

        }
    }
}
