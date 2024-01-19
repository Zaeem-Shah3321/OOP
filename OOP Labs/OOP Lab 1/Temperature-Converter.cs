using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.Write("Enter Temperature: ");
            temp = int.Parse(Console.ReadLine());
            string unit;
            Console.Write("Enter Unit (C/F): ");
            unit = Console.ReadLine();
            int new_temp = 0;
            string new_unit = "";
            if (unit == "c" || unit == "C")
            {
                new_temp = temp * 9 / 5 + 32;
                new_unit = "F";
            }
            else if (unit == "f" || unit == "F")
            {
                new_temp = (temp - 32) * 5 / 9;
                new_unit = "C";
            }
            Console.Write($"{temp}{unit} is equal to {new_temp}{new_unit}");
            Console.Read();
        }
    }
}
