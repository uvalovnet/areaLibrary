using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaLibrary
{
    public class Calculate
    {
        public double Area(double radius)
        {
            return new Circle(radius).area;
        }

        public double Area(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC).area;
        }
    }
}
