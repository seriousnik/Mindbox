using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GeometryMindbox
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона треугольника должна быть больше нуля!");
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона треугольника должна быть больше нуля!");
                b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона треугольника должна быть больше нуля!");
                c = value;
            }
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            if (!IsTriangleValid())
                throw new ArgumentException("Треугольник с такими сторонами не существует!");
        }
        public bool IsTriangleRectangular()
        {
            if (!IsTriangleValid())
                throw new ArgumentException("Треугольник с такими сторонами не существует!");
            var sidesArr = new double[] { a, b, c }.OrderByDescending(e => e).ToArray();
            return Math.Abs(Math.Pow(sidesArr[0], 2) - Math.Pow(sidesArr[1], 2) - Math.Pow(sidesArr[2], 2)) < 10e-5;
        }
        public bool IsTriangleValid() => (a < (b + c) && b < (a + c) && c < (a + b));
        public override double GetArea()
        {
            if (!IsTriangleValid())
                throw new ArgumentException("Треугольник с такими сторонами не существует!");
            double halfPer = (a + b + c) / 2.0;
            return Math.Pow(halfPer * (halfPer - a) * (halfPer - b) * (halfPer - c), 0.5);
        }
    }
}
