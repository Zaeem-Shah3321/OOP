using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labtask1.UI;
using labtask1.BL;
using labtask1.DL;

namespace labtask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = 0;
                MenuUI.Menu();
                choice = int.Parse((Console.ReadLine()));
                if (choice == 1)
                {
                    StudentsDL.AddStudent();
                }
                else if (choice == 8)
                {
                    return;
                }
                Console.ReadKey();
            }
        }
    }
}
