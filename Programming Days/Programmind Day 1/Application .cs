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
            const int size = 100;
            int count = 0;
            string[] names = new string[size];
            string[] passwords = new string[size];
            int book_count = 0;
            string[] books = new string[size];
            string[] book_location = new string[size];
            string[] copies = new string[size];
            string[] available = new string[size];
            string opt = "";

            while (opt != "3")
            {
                Console.Clear();
                Console.WriteLine("1. Sign Up..");
                Console.WriteLine("2. Sign In..");
                Console.Write("Enter Your Option..");
                opt = Console.ReadLine();
                if (opt == "1")
                {
                    signup(names, passwords, ref count);
                }
                else if(opt == "2")
                {

                    if (signin(names, passwords, count))
                    {
                        break;
                    }
                }
                else if (opt == "3")
                {
                    return;
                }
            }
            string user_option = "";
            Console.Write("Enter Option: ");
            user_option = Console.ReadLine();
            while (user_option != "5")
            {
                user_option = user_menu();
                if (user_option == "1")
                {
                    add_book(books,book_location,copies,available,ref book_count);
                }
                else if (user_option == "2")
                {
                    view_books(books,book_location,copies,available,book_count);
                }
                else if (user_option == "3")
                {
                    add_admin(names, passwords, ref count);
                }
                else if (user_option == "4")
                {
                    search_book(books, book_location, copies, available, book_count);
                }
                else if (user_option == "5")
                {
                    return;
                }
            }
        }
        static void signup(string[] name, string[] password, ref int count)
        {
            Console.Clear();
            string nam;
            Console.Write("Enter Your Name: ");
            nam = Console.ReadLine();
            string pass;
            Console.Write("Enter Your Password: ");
            pass = Console.ReadLine();
            Console.WriteLine("SignUp Secessfull..");
            Console.Write("Press Enter to Continue..");
            Console.Read();
            name[count] = nam;
            password[count] = pass;
            count++;
        }
        static bool signin(string[] name, string[] password, int count)
        {
            Console.Clear();
            string uName;
            Console.Write("Enter Username: ");
            uName = Console.ReadLine();
            string uPass;
            Console.Write("Enter Your: ");
            uPass = Console.ReadLine();
            bool ans = false;
            for (int x = 0; x < count; x++)
            {
                if (uName == name[x] && uPass == password[x])
                {
                    ans = true;
                }
                else
                {
                    ans = false;
                }
            }
            if (ans)
            {
                Console.WriteLine("Signed In Sucessfully");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("Press Enter to Continue..");
            Console.Read();
            return ans;
        }
        static string user_menu()
        {
            Console.Clear();
            string choice;
            Console.WriteLine("1. Add Book.. ");
            Console.WriteLine("2. View Books.. "); 
            Console.WriteLine("3. Add Admin.. ");
            Console.WriteLine("4. Search Book.. ");
            Console.WriteLine("5. Log Out.. ");
            Console.Write("Enter Your Option..");
            choice = Console.ReadLine();
            return choice;
        }
        static void add_book(string[] books, string[] book_location, string[] copies, string[] available, ref int book_count)
        {
            Console.Clear();
            string Bname;
            Console.Write("Enter Book Name: ");
            Bname = Console.ReadLine();
            string Blocation;
            Console.Write("Enter Book Location: ");
            Blocation = Console.ReadLine();
            string Bcopies;
            Console.Write("Enter Total Copies: ");
            Bcopies = Console.ReadLine();
            string Bavailable;
            Console.Write("Enter Copies Available: ");
            Bavailable = Console.ReadLine();
            bool flag = true;
            for (int x = 0; x < book_count; x++)
            {
                if (Bname == books[x])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }

            }
            if (flag == true)
            {
                Console.WriteLine("Book Added Sucessfuly..");
                books[book_count] = Bname;
                book_location[book_count] = Blocation;
                copies[book_count] = Bcopies;
                available[book_count] = Bavailable;
                book_count++;
            }
            else if (flag == false)
            {
                Console.WriteLine("Book Already Exist..");
            }
            Console.Write("Press Enter to Continue..");
            Console.Read();
        }
        static void view_books(string[] books, string[] book_location, string[] copies, string[] available, int book_count)
        {
            Console.Clear();
            Console.WriteLine("Serial No. \tBook Name \t     Book Location \t Total Copies \t Copies Available");
            for (int x = 0; x < book_count; x++)
            {
                Console.WriteLine($"{x}             \t{books[x]} \t                    {book_location[x]} \t                {copies[x]} \t              {available[x]}");
            }
            Console.Write("Press Enter to Continue..");
            Console.Read();
        }
        static void add_admin(string[] name, string[] password, ref int count)
        {
            Console.Clear();
            string Anam;
            Console.Write("Enter Name: ");
            Anam = Console.ReadLine();
            string Apass;
            Console.Write("Enter Password: ");
            Apass = Console.ReadLine();
            bool flag = false;
            for (int x = 0; x < count; x++)
            {
                if (Anam == name[x] && Apass == password[x])
                {
                    flag = false;
                }
                else
                {
                    flag = true;                   
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Admin Already Exist");
            }
            else if (flag == true)
            {
                Console.WriteLine("Admin added Secessfull..");
                Console.Write("Press Enter to Continue..");
                name[count] = Anam;
                password[count] = Apass;
                count++;
                Console.Read();
            }
            Console.Write("Press Enter to Continue..");
            Console.Read();
        }
        static void search_book(string[] books, string [] book_location, string[] copies, string[] available, int book_count)
        {
            Console.Clear();
            string BKname;
            Console.Write("Enter The Name Of The Book You Are Searching For: ");
            BKname = Console.ReadLine();
            bool flag = false;
            Console.WriteLine("Serial No. \tBook Name \t     Book Location \t Total Copies \t Copies Available");
            for (int x = 0; x < book_count; x++)
            {
                if (BKname == books[x])
                {
                    Console.WriteLine($"{x}             \t{books[x]} \t                    {book_location[x]} \t                {copies[x]} \t              {available[x]}");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Book Doesn't Exist..");
            }
            Console.Write("Press Enter to Continue..");
            Console.Read();
        }
    }
}
