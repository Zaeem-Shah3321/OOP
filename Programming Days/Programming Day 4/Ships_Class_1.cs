using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    class Ships
    {
        public string serialNumber;
        public Angle longitude;
        public Angle latitude;
        public Ships(string serial, Angle Latitude, Angle Longitude)
        {
            serialNumber = serial;
            latitude = Latitude;
            longitude = Longitude;
        }
    }

}
