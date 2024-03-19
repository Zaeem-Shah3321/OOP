using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chawan
{
    internal class MountainBike:Bicycle
    {
        private int seatheight;
        public MountainBike(int seatheight, int cadance, int gear, int speed): base (cadance,gear,speed)
        {
            this.seatheight = seatheight;
        }
        public void Seatheight(int heights)
        {
            seatheight = heights;
        }
    }
}
