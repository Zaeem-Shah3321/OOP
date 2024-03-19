using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab6.BL;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books("Harry Potter");
            books.GetTitle();
            Console.WriteLine("Book Title: " + books.GetTitle());
            Console.ReadKey();
        }
    }
}
