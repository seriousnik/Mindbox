using System;
using GeometryMindbox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGeometry
{
    [TestClass]
    public class UnitTest1
    {
        Triangle t1 = new Triangle(3, 4, 5);
        Triangle t2 = new Triangle(2.11, 1.79, 2.54);
        Triangle t3 = new Triangle(6, 9.9999999999, 8.0000001);

        Circle c1 = new Circle(3.91);
        Circle c2 = new Circle(2.5);
        private double GetShapeArea(Shape shape) => shape.GetArea();

        [TestMethod]
        public void TriangleDoesNotExist()
        {           
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1,1,2));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(2.2, 3.7, 15.91));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-2, 1, 0.5));
        }

        [TestMethod]
        public void CircleDoesNotExist()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-2));
        }

        [TestMethod]
        public void GetCircleArea()
        {
            Assert.AreEqual(48.028982, GetShapeArea(c1), 10e-6);
            Assert.AreEqual(19.634954, GetShapeArea(c2), 10e-6);
        }

        [TestMethod]
        public void GetTriangleArea()
        {
            Assert.AreEqual(6, GetShapeArea(t1));
            Assert.AreEqual(1.864283, GetShapeArea(t2), 10e-6);
            Assert.AreEqual(24, GetShapeArea(t3), 10e-6);
        }

        [TestMethod]
        public void IsTriangleRectangular()
        {
            Assert.AreEqual(true, t1.IsTriangleRectangular());
            Assert.AreEqual(false, t2.IsTriangleRectangular());
            Assert.AreEqual(true, t3.IsTriangleRectangular());
        }

    }
}
