using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.BL
{
    internal class Books
    {
        private string Title;
        private Authors AuthorName;
        public Books(string Titles)
        {
            Title = Titles;
            AuthorName = new Authors();
        } 
        public string GetTitle()
        {
            return Title;
        }
        public string SetTitle()
        {
            return Authors.SetName();
        }
    }
}
