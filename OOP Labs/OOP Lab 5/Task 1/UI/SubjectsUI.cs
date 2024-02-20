using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labtask1.BL;
using labtask1.DL;

namespace labtask1.UI
{
    class SubjectsUI
    {
        public static SubjectsBL GetSubjectInfo()
        {
            Console.Write("Enter Number of Subjects: ");
            int subjects = int.Parse(Console.ReadLine());
            Console.Write("Enter Subjects Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter Subject Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Credit Hours: ");
            int creditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees: ");
            int fees = int.Parse(Console.ReadLine());
            Console.Write("Press Any Key To Continue...");
            SubjectsBL subject = new SubjectsBL(code, creditHours, type, fees);
            return subject;
        }
    }
}
