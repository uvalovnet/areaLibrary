using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaLibrary
{
    public class Circle
    {
        public double radius;
        public double area;

        public Circle(double r)
        {
            radius = r;
            area = CalculateArea(r);
        }

        private double CalculateArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

    }

}

