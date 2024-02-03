using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 game = new Class1();

            while (true)
            {
                string[] array = new string[100];
                Console.Clear();
                Console.WriteLine("Shiritori");
                Console.WriteLine("1. You need to enter a word that starts with the last letter of the previous word.");
                Console.WriteLine("2. You can't repeat a word that has already been written.");
                Console.Write("The first word is: ");
                string word = Console.ReadLine();                
                bool a = game.Play(word);
                if (a == true)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
                Console.ReadKey();
            }
        }
    }
}
