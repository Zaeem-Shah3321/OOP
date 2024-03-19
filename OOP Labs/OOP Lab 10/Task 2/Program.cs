
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder (1.0 , 1.0, "Red");
            c1.getinfo();
            Console.ReadKey();
        }
    }
}
