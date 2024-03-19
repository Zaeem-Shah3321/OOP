using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Circle
    {
        private double radius;
        private string color; 

        public Circle()
        {
            radius = 1.0;
            color = "Red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
            color = "red";
        }
        public Circle(double radius, string color)
        {
            this.color = color;
            this.radius = radius;
        }
        public double getRadius() 
        {
            return radius;
        }
        public void setRadius(double radius)  
        {
            this.radius = radius;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public double getArea() 
        { 
            return radius * radius * Math.PI;
        } 
        public string toString() 
        {
            return "Circle\nRadius= " + radius + "\nColor= " + color + "";
        }
    }
}
