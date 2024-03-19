using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.BL
{
    internal class Authors
    {
        private string Name;
        public Authors()
        {
            Name = SetName();
        }
        public static string SetName()
        {
            Console.Write("Enter Author Name: ");
            string Name = Console.ReadLine();
            return Name;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
