using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labtask1.BL;

namespace labtask1.UI
{
    class StudentsUI
    {
        public static StudentsBL GetStudentData()
        {
            List<string> prefrencesList = new List<string>();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter FSC Marks: ");
            int fscMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter ECAT Marks: ");
            int ecatMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Preferences: ");
            int prefrences = int.Parse(Console.ReadLine());
            for (int x = 0; x < prefrences; x++)
            {
                Console.Write($"Enter Preference {x+1}: ");
                prefrencesList.Add(Console.ReadLine());
            }
            StudentsBL Student = new StudentsBL(name, age, fscMarks, ecatMarks, prefrencesList);
            Console.Write("Press Any Key To Continue...");  
            Console.ReadKey();
            return Student;
        }
    }
}
