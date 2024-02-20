using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labtask1.DL;
using labtask1.UI;

namespace labtask1.BL
{
    class StudentsBL
    {
        public string Name;
        public float Age;
        public int FscMarks;
        public int EcatMarks;
        public List<string> Prefrences;
        public StudentsBL(string name, float age, int fscmarks, int ecatmarks, List<string> prefrences)
        {
            Name = name;
            Age = age;
            FscMarks = fscmarks;
            EcatMarks = ecatmarks;
            Prefrences = prefrences;
        }
        public float CalculateMerit()
        {
            float merit = ((FscMarks/1100)*0.7F) + ((EcatMarks/400)*0.3F);
            return merit;
        }
    }
}
