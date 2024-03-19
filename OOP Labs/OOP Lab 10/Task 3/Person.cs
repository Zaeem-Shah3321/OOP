using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTask3
{
    internal class Person
    {
        private string name;
        private string address;
        public Person(string name, string adress)
        {
            this.name = name;
            this.address = adress;
        }
        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public string toString()
        {
            return "Person\nName: " + name + "\nAddress: " + address + "";
        }
    }
}
