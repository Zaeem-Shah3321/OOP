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
            const int size = 5;
            student[] s1 = new student[size];
            for (int x = 0; x < size; x++)
            {
                Console.Clear();
                s1[x] = takeinfo();
            }
            printData(s1);
            Console.ReadKey();
        }
        static student takeinfo()
        {
            student std = new student();
            Console.Write("Enter Name: ");
            std.name = Console.ReadLine();
            Console.Write("Enter FSc Marks: ");
            std.fscMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter Metric Marks: ");
            std.metricMarks = int.Parse(Console.ReadLine());
            return std;
        }
        static void printData(student[] ssd)
        {
            Console.Clear();
            Console.WriteLine("Name \t\t\t\t FSc Marks \t\t\t Matric Marks");
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine($"{ssd[x].name} \t\t\t\t   {ssd[x].fscMarks} \t\t\t\t     {ssd[x].metricMarks}");
            }
        }
    }
}
