using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Asad", "Green Town", "CS", 2023, 5000);
            Console.WriteLine(s.toString());
            Staff f = new Staff("Ali", "Model Town", "FAST", 50000);
            Console.WriteLine(f.toString());
            Console.ReadKey();
        }
    }
}
