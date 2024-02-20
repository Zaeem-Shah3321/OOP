using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labtask1.BL;
using labtask1.DL;

namespace labtask1.UI
{
    class DegreeUI
    {
        public static void GetDegreeInfo()
        {
            Console.Write("Enter Degree Name: ");
            string degreeName = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Enter Seats For Degree: ");
            int seats = int.Parse(Console.ReadLine());
            Console.Write("Press Any Key To Continue...");
            Console.ReadKey();
        }
    }
}
