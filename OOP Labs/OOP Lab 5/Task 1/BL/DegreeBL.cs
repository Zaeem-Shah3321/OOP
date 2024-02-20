using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labtask1.DL;
using labtask1.UI;

namespace labtask1.BL
{
    class DegreeBL
    {
        public string DegreeName;
        public int DuraTion;
        public DegreeBL(string name , int duration)
        {
            DegreeName = name;
            DuraTion = duration;
        }
    }
}
