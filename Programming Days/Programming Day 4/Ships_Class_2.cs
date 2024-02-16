using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    internal class Angle
    {
        public int degrees;
        public float minutes;
        public char direction;
        public Angle(int deg, float min, char dir)
        {
            degrees = deg;
            minutes = min;
            direction = dir;
        }
        public string location()
        {
            return ($"{degrees}\u00b0{minutes}' {direction} ");
        }
    }
}
