using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labtask1.DL;
using labtask1.UI;

namespace labtask1.BL
{
    class SubjectsBL
    {
        public string Code;
        public int CreditHours;
        public string Type;
        public int Fees;
        public SubjectsBL(string code, int credithours, string type, int fees)
        {
            Code = code;
            CreditHours = credithours;
            Type = type;
            Fees = fees;
        }
    }


}
