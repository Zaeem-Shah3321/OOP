using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace challanege3
{
    class Program
    {
        static string filePath = "users.txt";

        static void Main()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            users[] users = loadData(filePath);

            while (true)
            {
                int option = menu();
                if (option == 1)
                {
                    SignUp(users);
                }
                else if (option == 2)
                {
                    SignIn(users);
                }
                else if (option == 3)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
                Console.ReadKey();
            }
        }
        static int menu()
        {
            int opt = 0;
            Console.Clear();
            Console.WriteLine("1. SignUp");
            Console.WriteLine("2. SignIn");
            Console.WriteLine("3. Exit");
            opt = int.Parse(Console.ReadLine());
            return opt;
        }

        static void SignUp(users[] users)
        {
            Console.Clear();
            Console.Write("Enter Username:");
            string username = Console.ReadLine();
            Console.Write("Enter Password:");
            string password = Console.ReadLine();
            Console.Write("Enter Your Role:");
            string role = Console.ReadLine();
            users newUser = new users(username, password, role);
            users = users.Append(newUser).ToArray();
            savedata(users);
            Console.WriteLine("SignUp successful!");
        }

        static void SignIn(users[] users)
        {
            Console.Clear();
            users = loadData(filePath);
            Console.Write("Enter Username:");
            string username = Console.ReadLine();
            Console.Write("Enter Password:");
            string password = Console.ReadLine();
            users user = null;
            for (int x = 0; x < users.Length; x++)
            {
                if (users[x].Username == username && users[x].Password == password)
                {
                    user = users[x];
                    break;
                }
            }
            if (user != null)
            {
                Console.WriteLine($"Welcome, {user.Role}!");
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }
        }

        static users[] loadData(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                users[] users = new users[lines.Length];

                for (int x = 0; x < lines.Length; x++)
                {
                    string[] parts = lines[x].Split(',');
                    string username = parts[0];
                    string password = parts[1];
                    string role = parts[2];

                    users[x] = new users(username, password, role);
                }

                return users;
            }
            else
            {
                return new users[0];
            }
        }

        static void savedata(users[] users)
        {
            string[] userLines = new string[users.Length];

            for (int x = 0; x < users.Length; x++)
            {
                userLines[x] = $"{users[x].Username},{users[x].Password},{users[x].Role}";
            }

            File.WriteAllLines(filePath, userLines);
        }
    }
}
