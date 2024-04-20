using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.BL
{
    internal class User:Person
    {
        private string rollno;
        private List <Book> books;
        public User(string name, string password, string role,string rollno): base(name, password,role)
        {
            this.rollno = rollno;
            books = new List<Book>();
        }
    }
}
