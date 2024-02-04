using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Student
    {
        public string name;
        public float matric;
        public float inter;
        public float ecat;
        public float aggregate;
        public Student(string Name, float Matric, float Fsc, float Ecat)
        {
            name = Name;
            matric = Matric;
            inter = Fsc;
            ecat = Ecat;
        }
        public void aggregates()
        {
            aggregate = (matric * 30 / 1100) + (inter * 20 / 1100) + (ecat * 50 / 1100);
        }
    }
}
