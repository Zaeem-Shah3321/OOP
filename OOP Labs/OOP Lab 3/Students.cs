using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        static void Main()
        {
            const int size = 100;
            Student[] students = new Student[size];
            int count = 0;
            while (true)
            {
                int options = menu();
                if (options == 1)
                {
                    students[count] = addstudent();
                    count++;
                }
                else if (options == 2)
                {
                    showstudents(students);
                }
                else if (options == 3)
                {
                    aggregate(students);
                    Console.WriteLine("Agreegate calculated use option 2 to see them");
                }
                else if (options == 4)
                {
                    aggregate(students);
                    aggregateSorting(students);
                    showstudents(students);
                }
                Console.ReadKey();
            }
        }
        static int menu()
        {
            Console.Clear();
            int opt = 0;
            Console.WriteLine("1. Add students");
            Console.WriteLine("2. Show students");
            Console.WriteLine("3. Calculate Aggregate");
            Console.WriteLine("4. Top students");
            Console.Write("Enter Your Option: ");
            opt = int.Parse(Console.ReadLine());
            return opt;
        }
        static Student addstudent()
        {
            Console.Clear();
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Matric marks: ");
            int matric = int.Parse(Console.ReadLine());
            Console.Write("Enter Fsc marks: ");
            int inter = int.Parse(Console.ReadLine());
            Console.Write("Enter Ecat marks: ");
            int ecat = int.Parse(Console.ReadLine());
            Student studentss = new Student(name, matric, inter, ecat);
            return studentss;
        }
        static void showstudents(Student[] students)
        {
            Console.Clear();
            Console.WriteLine("Name\t       Matric marks\t\t         Fsc marks\t\t        Ecat marks\t\t          Aggregate");
            for (int x = 0; students[x] != null; x++)
            {
                Console.WriteLine($"{students[x].name}   \t   {students[x].matric}   \t\t\t   {students[x].inter}   \t\t\t    {students[x].ecat}    \t\t\t    {students[x].aggregate}");
            }
        }

        static void aggregate(Student[] students)
        {
            Console.Clear();
            for (int x = 0; students[x] != null; x++)
            {
                students[x].aggregates();
            }
        }
        static void aggregateSorting(Student[] students)
        {
            Console.Clear();
            int number = students.Length;
            int[] result = new int[3];
            for (int x = 0; x < number - 1; x++)
            {
                for (int y = 0; y < number - 1 - x; y++)
                {
                    if (students[y] != null && students[y + 1] != null && students[y].aggregate != null && students[y + 1].aggregate != null)
                    {

                        if (students[y].aggregate < students[y + 1].aggregate)
                        {
                            Student temp = students[y];
                            students[y] = students[y + 1];
                            students[y + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}
