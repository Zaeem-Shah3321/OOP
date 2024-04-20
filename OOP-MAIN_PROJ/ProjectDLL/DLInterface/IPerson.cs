using ProjectDLL.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.DLInterface
{
    public interface IPerson
    {
        void Create(Person person);
        Person Read (string name);
        Person signin(Person person);
        bool IsExist(string name);


    }
}
