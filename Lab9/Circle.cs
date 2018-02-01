using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    //CLASS//
    class Circle
    {
        //INSTANCE VARIABLES//
        private double radius;
        private const double pi = Math.PI;
        
        //CONSTRUCTOR//
        public Circle(double r)
        {
            radius = r;
        }
        //METHOD//
        public double CalculateCircumference()
        {
            double circumference = 2 * pi * radius;
            return circumference;
        }

        public string CalculateFormattedCircumference()
        {
            double c = CalculateCircumference();
            c = Math.Round(c, 2);
            return c.ToString();
        }

        public double CalculateArea()
        {
            double area = pi * radius * radius;
            return area;
        }

        public string CalculateFormattedArea()
        {
            double a = CalculateArea();
            a = Math.Round(a, 2);
            return a.ToString();
        }
    }
}
