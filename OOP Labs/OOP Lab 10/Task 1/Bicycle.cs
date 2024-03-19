using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chawan
{
    internal class Bicycle
    {
        protected int candance;
        protected int gear;
        protected int speed;
        public Bicycle(int candance, int gear, int speed)
        {
            this.candance = candance;
            this.gear = gear;
            this.speed = speed;
            Console.WriteLine("Added Sussesfully");
            showinfo();
        }
        public void setcandance(int cadance)
        {
            candance = cadance;
        }
        public void stegear(int gears)
        {
            gear = gears;
        }
        public void applybreak(int decrement)
        {
            speed -= decrement;
        }
        public void speedup(int increment)
        {
            speed += increment;
        }
        public void showinfo()
        {
            Console.WriteLine($"Cadance: {candance}\nGear: {gear}\nSpeed: {speed}");
        }
    
    }
}
