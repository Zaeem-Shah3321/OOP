using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Cylinder:Circle
    {
        private double height;
        public Cylinder()
        {
            height = 1.0;
        }
        public Cylinder(double radius) : base(radius)
        {
            
        }
        public Cylinder (double radius, double height) : base(radius)
        {
            this.height = 1.0;
        }
        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            this.height = 1.0;
        }
        public double getHeight()
        {
            return height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            return getArea() * height;
        }
        public void getinfo()
        {
            Console.WriteLine(toString());
            Console.WriteLine($"Area: {getArea()}");
            Console.WriteLine($"Volume: {getVolume()}");
        }
    }
}
