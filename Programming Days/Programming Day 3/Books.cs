using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();

            while (true)
            {
                int option = menu();
                if (option == 1)
                {
                    add_books(bookList);
                }
                else if (option == 2)
                {
                    book_info(bookList);
                }
                else if (option == 3)
                {
                    book_author(bookList);
                }
                else if (option == 4)
                {
                    sell_copies(bookList);
                }
                else if (option == 5)
                {
                    restock(bookList);
                }
                else if (option == 6)
                {
                    Console.WriteLine($"Total Number Of Books: {bookList.Count}");
                }
                else if (option == 7)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.ReadKey();
            }
        }
        static int menu()
        {
            int opt = 0;
            Console.Clear();
            Console.WriteLine("1. Add Books");
            Console.WriteLine("2. View All the Books");
            Console.WriteLine("3. See Author's Name");
            Console.WriteLine("4. Sell Books");
            Console.WriteLine("5. Restock Books");
            Console.WriteLine("6. Viwe Total Number Of Books");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            opt = int.Parse(Console.ReadLine());
            return opt;
        }
        static void add_books(List<Book> bookList)
        {
            Console.Clear();
            Console.Write("Enter Book Name: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();
            Console.Write("Enter Publication Year: ");
            int publicationYear = int.Parse(Console.ReadLine());
            Console.Write("Enter Book Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number Of Books In Stock: ");
            int quantityInStock = int.Parse(Console.ReadLine());
            Book newBook = new Book(title, author, publicationYear, price, quantityInStock);
            bookList.Add(newBook);
            Console.WriteLine("Book Added Successfully.");
        }
        static void book_info(List<Book> bookList)
        {
            Console.Clear();
            Console.WriteLine("Book Information:");
            foreach (Book book in bookList)
            {
                Console.WriteLine(book.BookDetails());
                Console.WriteLine();
            }
        }
        static void book_author(List<Book> bookList)
        {
            Console.Clear();
            Console.Write("Enter the title of the book: ");
            string searchTitle = Console.ReadLine();
            bool found = false;

            foreach (Book book in bookList)
            {
                if (book.Title.Contains(searchTitle))
                {
                    Console.WriteLine(book.GetAuthor());
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found.");
            }
        }
        static void sell_copies(List<Book> bookList)
        {
            Console.Clear();
            Console.Write("Enter the title of the book: ");
            string sellTitle = Console.ReadLine();
            bool foundBook = false;

            foreach (Book book in bookList)
            {
                if (book.Title.Contains(sellTitle))
                {
                    Console.Write("Enter the number of copies to sell: ");
                    int numberOfCopies = int.Parse(Console.ReadLine());
                    book.SellCopies(numberOfCopies);
                    foundBook = true;
                    break;
                }
            }

            if (!foundBook)
            {
                Console.WriteLine("Book not found.");
            }
        }
        static void restock(List<Book> bookList)
        {
            Console.Clear();
            Console.Write("Enter the title of the book: ");
            string restockTitle = Console.ReadLine();
            bool foundBookToRestock = false;

            foreach (Book book in bookList)
            {
                if (book.Title.Contains(restockTitle))
                {
                    Console.Write("Enter the number of copies to restock: ");
                    int additionalCopies = int.Parse(Console.ReadLine());
                    book.Restock(additionalCopies);
                    foundBookToRestock = true;
                    break;
                }
            }
            if (!foundBookToRestock)
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}