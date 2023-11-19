using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaLibrary
{
    public class Triangle
    {
        public double sideA;
        public double sideB;
        public double sideC;
        public double area;
        public bool isRightTriangle;

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
            area = CalculateArea(a, b, c);
            isRightTriangle = IsRightTriangle(a, b, c);
        }

        private double CalculateArea(double a, double b, double c)
        {
            var p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        private bool IsRightTriangle(double a, double b, double c)
        {
            var pifagor = new List<double>() { a, b, c };
            pifagor.OrderByDescending(x => x);

            if (Math.Pow(pifagor[0], 2) == Math.Pow(pifagor[1], 2) + Math.Pow(pifagor[2], 2)) { return true; }

            return false;
        }
    }
}
