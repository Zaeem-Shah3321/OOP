using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Product
    {
        public int ID;
        public string Name;
        public float Price;
        public string Category;
        public string BrandName;
        public string Country;
        public Product(int iD, string name, float price, string category, string brandName, string country)
        {
            ID = iD;
            Name = name;
            Price = price;
            Category = category;
            BrandName = brandName;
            Country = country;
        }
    }
}
