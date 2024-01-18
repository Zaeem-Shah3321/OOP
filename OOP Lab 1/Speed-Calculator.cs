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
            int distance;
            Console.Write("Enter Distance (km): ");
            distance = int.Parse(Console.ReadLine());
            int time;
            Console.Write("Enter Time (h): ");
            time = int.Parse(Console.ReadLine());
            int speed;
            speed = distance / time;
            Console.WriteLine($"Speed is {speed}km/h.");
            Console.Read();
        }
    }
}
