using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XWAssignment2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void Analyze_Given1And2And4_ResultIsNoTriangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(1, 2, 4);

            //Assert
            Assert.AreEqual("no triangle", result);
        }

        [Test]
        public void Analyze_Given4And2And2_ResultIsNoTriangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(4, 2, 2);

            //Assert
            Assert.AreEqual("no triangle", result);
        }

        [Test]
        public void Analyze_Given2And2And2_ResultIsEquilateralTriangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(2, 2, 2);

            //Assert
            Assert.AreEqual("equilateral triangle", result);
        }

        [Test]
        public void Analyze_Given3And2And2_ResultIsIsoscelesTriangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(3, 2, 2);

            //Assert
            Assert.AreEqual("isosceles triangle", result);
        }

        [Test]
        public void Analyze_Given2And1And2_ResultIsIsoscelesTriangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(2, 1, 2);

            //Assert
            Assert.AreEqual("isosceles triangle", result);
        }

        [Test]
        public void Analyze_Given24And16And20_ResultIsScaleneTriangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(24, 16, 20);

            //Assert
            Assert.AreEqual("scalene triangle", result);
        }
    }
}
