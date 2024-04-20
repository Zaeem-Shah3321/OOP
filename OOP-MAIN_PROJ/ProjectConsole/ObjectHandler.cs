using ProjectDLL.DL.DB;
using ProjectDLL.DLInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConsole
{
    internal class ObjectHandler
    {
        private static IBook BookDl = new BookDB();
        private static IPerson PersonDl = new PersonDB();

        public static IBook GetBookDL()
        {
            return BookDl;
        }
        public static IPerson GetPersonDL()
        {
            return PersonDl;
        }

    }
}
