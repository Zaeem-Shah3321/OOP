using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student("Zaeem" , 1000 , 1065);
            Console.Write("Name: ");
            Console.WriteLine(s1.name);
            Console.Write("FSc Marks: ");
            Console.WriteLine(s1.fscMarks);
            Console.Write("Matric Marks: ");
            Console.WriteLine(s1.mMarks);

            //Console.WriteLine(s1.mMarks);
            Console.ReadKey();
        }
    }
}
