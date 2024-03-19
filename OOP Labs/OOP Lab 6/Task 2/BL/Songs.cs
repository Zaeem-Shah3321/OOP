using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.BL
{
    internal class Songs
    {
        private string Title;
        public Songs(string title)
        {
            Title = title;
        }
        public string getTitle()
        {
            return Title;
        }
    }
}
