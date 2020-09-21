using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircleWork;

namespace ConsoleWorkTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Set_Circle_With_Invalid_Radius_Should_Throw_ArgumentOutOfRangeException()
        {
            //Arrange
            double r = -4;
            Circle circle = new Circle();

            //Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => circle.R = r);

        }

        [TestMethod]
        public void Circle_With_Valid_Radius_Get_Area()
        {
            //Arrange
            double r = 4;
            double expected = 50.265;
            Circle circle = new Circle();

            //Act
            circle.R = r;
            double actual = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Area wasn't calculated correctly");

        }

        [TestMethod]
        public void Circle_With_Valid_Radius_Get_Perimeter()
        {
            //Arrange
            double r = 4;
            double expected = 25.133;
            Circle circle = new Circle();

            //Act
            circle.R = r;
            double actual = circle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Area wasn't calculated correctly");

        }

        [TestMethod]
        public void Circle_With_Same_Radius_Is_Circles_Equals()
        {
            //Arrange
            double r1 = 4.2;
            double r2 = 4.2;
            bool expected = true;
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();

            //Act
            circle1.R = r1;
            circle2.R = r2;
            bool actual = circle1.IsCircleEquals(circle2);

            //Assert
            Assert.AreEqual(expected, actual, "Circles are not Equals");

        }

        [TestMethod]
        public void Circle_With_Different_Radius_Is_Circles_Equals()
        {
            //Arrange
            double r1 = 4.2;
            double r2 = 4.3;
            bool expected = false;
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();

            //Act
            circle1.R = r1;
            circle2.R = r2;
            bool actual = circle1.IsCircleEquals(circle2);

            //Assert
            Assert.AreEqual(expected, actual, "Circles are Equals");

        }

        [TestMethod]
        public void Circles_Are_Too_Far_Apart_Do_Not_Intersect()
        {
            //Arrange
            double x1 = 1.1;
            double y1 = 1.2;
            double r1 = 4.1;
            double x2 = 11.1;
            double y2 = 11.2;
            double r2 = 4.2;
            bool expected = false;
            Circle circle1 = new Circle(x1, y1, r1);
            Circle circle2 = new Circle(x2, y2, r2);

            //Act
            bool actual = circle1.IsCirclesIntersect(circle2);

            //Assert
            Assert.AreEqual(expected, actual, "Circles are intersect");

        }

        [TestMethod]
        public void One_Circle_Contains_Other_Circles_Do_Not_Intersect()
        {
            //Arrange
            double x1 = 1.1;
            double y1 = 1.2;
            double r1 = 10.1;
            double x2 = 1.1;
            double y2 = 1.2;
            double r2 = 4.2;
            bool expected = false;
            Circle circle1 = new Circle(x1, y1, r1);
            Circle circle2 = new Circle(x2, y2, r2);

            //Act
            bool actual = circle1.IsCirclesIntersect(circle2);

            //Assert
            Assert.AreEqual(expected, actual, "Circles are intersect");

        }

        [TestMethod]
        public void Circles_Coinside_Do_Not_Intersect()
        {
            //Arrange
            double x1 = 1.1;
            double y1 = 1.2;
            double r1 = 4.1;
            double x2 = 1.1;
            double y2 = 1.2;
            double r2 = 4.1;
            bool expected = false;
            Circle circle1 = new Circle(x1, y1, r1);
            Circle circle2 = new Circle(x2, y2, r2);

            //Act
            bool actual = circle1.IsCirclesIntersect(circle2);

            //Assert
            Assert.AreEqual(expected, actual, "Circles are intersect");

        }

        [TestMethod]
        public void Circles_Are_Intersect()
        {
            //Arrange
            double x1 = 1.1;
            double y1 = 1.2;
            double r1 = 4.1;
            double x2 = 5.1;
            double y2 = 5.2;
            double r2 = 7.1;
            bool expected = true;
            Circle circle1 = new Circle(x1, y1, r1);
            Circle circle2 = new Circle(x2, y2, r2);

            //Act
            bool actual = circle1.IsCirclesIntersect(circle2);

            //Assert
            Assert.AreEqual(expected, actual, "Circles do not intersect");

        }

        [TestMethod]
        public void Circles_Are_Concentric()
        {
            //Arrange
            double x1 = 1.1;
            double y1 = 1.2;
            double r1 = 4.1;
            double x2 = 1.1;
            double y2 = 1.2;
            double r2 = 7.1;
            bool expected = true;
            Circle circle1 = new Circle(x1, y1, r1);
            Circle circle2 = new Circle(x2, y2, r2);

            //Act
            bool actual = circle1.IsCiclesConcentric(circle2);

            //Assert
            Assert.AreEqual(expected, actual, "Circles are not concentric");
        }

        [TestMethod]
        public void Circles_Are_Not_Concentric()
        {
            //Arrange
            double x1 = 1.1;
            double y1 = 1.2;
            double r1 = 4.1;
            double x2 = 5.1;
            double y2 = 5.2;
            double r2 = 7.1;
            bool expected = false;
            Circle circle1 = new Circle(x1, y1, r1);
            Circle circle2 = new Circle(x2, y2, r2);

            //Act
            bool actual = circle1.IsCiclesConcentric(circle2);

            //Assert
            Assert.AreEqual(expected, actual, "Circles are concentric");

        }



    }
}
