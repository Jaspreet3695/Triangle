using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleAssignment;

namespace TriangleTest.cs
{
    [TestFixture]
     class UnitTests
    {
        [Test]
        public void Analyze_Input1and11and1_ReturnsNotValid()
        {
            //Arrange
            int side1 = 1;
            int side2 = 11;
            int side3 = 1;      //chose these values because sum of side1 and side3 entered is less than the side2.

            //Act
            string expectedResult = "not a valid triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input3and3and3_ReturnsEquilateral()
        {
            //Arrange
            int side1 = 3;
            int side2 = 3;
            int side3 = 3;      //chose these values to test the equilateral triangle condition.

            //Act
            string expectedResult = "Equilateral Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input10and10and3_ReturnsIsosceles()
        {
            //Arrange
            int side1 = 10;
            int side2 = 10;
            int side3 = 3;      //chose these values to test the isosceles triangle condition where side1 and side2 are equal.

            //Act
            string expectedResult = "Isosceles Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input4and5and3_ReturnsScalene()
        {
            //Arrange
            int side1 = 4;
            int side2 = 5;
            int side3 = 3;      //chose these values to test the scalene triangle condition where no sides are equal.

            //Act
            string expectedResult = "Scalene Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input5and5and10_ReturnsNotValid()
        {
            //Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 10;     //chose these values because sum of side1 and side2 is equal to side3, should also fall in not valid category.

            //Act
            string expectedResult = "not a valid triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input25and30and30_ReturnsIsosceles()
        {
            //Arrange
            int side1 = 25;
            int side2 = 30;
            int side3 = 30;     //chose these values to test the isosceles triangle condition where side2 and side3 are equal.

            //Act
            string expectedResult = "Isosceles Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_Input6and10and6_ReturnsIsosceles()
        {
            //Arrange
            int side1 = 6;
            int side2 = 10;
            int side3 = 6;      //chose these values to test the isosceles triangle condition where side1 and side3 are equal.

            //Act
            string expectedResult = "Isosceles Triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_Input4and4and10_ReturnsNotValid()
        {
            //Arrange
            int side1 = 4;
            int side2 = 4;
            int side3 = 10;      //chose these values because sum of side1 and side2 entered is less than the side3.

            //Act
            string expectedResult = "not a valid triangle";
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
