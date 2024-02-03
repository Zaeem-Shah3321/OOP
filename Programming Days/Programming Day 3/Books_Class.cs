using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Book
    {

        public string Title;
        public string Author;
        public int Year;
        public double Price;
        public int Quantity;

        public Book(string title, string author, int year, double price, int quantity)
        {
            Title = title;
            Author = author;
            Year = year;
            Price = price;
            Quantity = quantity;
        }

        public string GetTitle()
        {
            return $"Title: {Title}";
        }

        public string GetAuthor()
        {
            return $"Author: {Author}";
        }

        public string GetPublicationYear()
        {
            return $"Publication Year: {Year}";
        }

        public string GetPrice()
        {
            return $"Price: {Price}";
        }

        public void SellCopies(int copies)
        {
            if (copies <= Quantity)
            {
                Quantity -= copies;
                Console.WriteLine($"{copies} Copies Of {Title} Sold.");
            }
            else
            {
                Console.WriteLine($"Insufficient Stock. Only {Quantity} Copies Of {Title} Left.");
            }
        }

        public void Restock(int moreCopies)
        {
            Quantity += moreCopies;
            Console.WriteLine($"{moreCopies} Copies of {Title} Added To Stock.");
        }

        public string BookDetails()
        {
            return $"Title: {Title}\nAuthor: {Author}\nPublication Year: {Year}\nPrice: {Price}\nQuantity in Stock: {Quantity}";
        }
    }
}
