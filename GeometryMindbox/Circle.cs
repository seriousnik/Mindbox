using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryMindbox
{
    public class Circle : Shape
    {
        private double r;
        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Радиус должен быть положительным");
                r = value;
            }
        }

        public Circle(double r)
        {
            R = r;
        }
        public override double GetArea() => Math.PI * Math.Pow(r, 2);
    }
}
