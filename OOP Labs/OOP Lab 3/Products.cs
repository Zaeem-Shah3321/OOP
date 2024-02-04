using System;

namespace Challenge_2
{
    internal class Program
    {
        const int size = 100;
        static Product[] products = new Product[size];
        static int count = 0;

        static void Main()
        {
            while (true)
            {
                int options = menu();

                if (options == 1)
                {
                    AddProduct();
                }
                else if (options == 2)
                {
                    ShowProducts(count, products);
                }
                else if (options == 3)
                {
                    totalworth(count, products);
                }
                else if (options == 4)
                {
                    return;
                }

                Console.ReadKey();
            }
        }

        static int menu()
        {
            Console.Clear();
            int opt = 0;
            Console.WriteLine("1. Add Products");
            Console.WriteLine("2. Show Products");
            Console.WriteLine("3. Total Store Worth");
            Console.WriteLine("4. Exit");
            Console.Write("Enter Your Option");
            opt = int.Parse(Console.ReadLine());
            return opt;
        }

        static void ShowProducts(int count, Product[] products)
        {
            Console.Clear();
            Console.WriteLine("ID\tName\tPrice\tCategory\tBrand\tCountry");
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine($"{products[x].ID}\t{products[x].Name}\t{products[x].Price}\t{products[x].Category}\t\t{products[x].BrandName}\t{products[x].Country}");
            }
        }

        static void totalworth(int count, Product[] products)
        {
            Console.Clear();
            float totalWorth = 0;
            for (int x = 0; x < count; x++)
            {
                totalWorth += products[x].Price;
            }
            Console.WriteLine($"Total Store Worth: {totalWorth}");
        }

        static void AddProduct()
        {
            Console.Clear();
            Console.Write("Enter ID: ");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Price: ");
            float Price = float.Parse(Console.ReadLine());
            Console.Write("Enter Category: ");
            string Category = Console.ReadLine();
            Console.Write("Enter BrandName: ");
            string BrandName = Console.ReadLine();
            Console.Write("Enter Country: ");
            string Country = Console.ReadLine();
            Product product = new Product(ID, Name, Price, Category, BrandName, Country);
            products[count] = product;
            count++;
        }
    }
}
