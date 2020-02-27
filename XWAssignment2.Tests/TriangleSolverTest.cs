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
        /// <summary>
        /// First situation that cannot make a triangle,
        /// which is the longest side is greater than sum of the other two sides
        /// </summary>
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

        /// <summary>
        /// Second situation that cannot make a triangle
        /// which is the longest side equals to sum of the other two sides
        /// </summary>
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

        /// <summary>
        /// If the three side can make a triangle,
        /// The only situation that can make a Equilateral Triangle
        /// which is the three sides are all same
        /// </summary>
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

        /// <summary>
        /// If the three side can make a triangle,
        /// First situation that can make a Isosceles Triangle
        /// which is the two shorter sides are same
        /// </summary>
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

        /// <summary>
        /// If the three side can make a triangle,
        /// Second situation that can make a Isosceles Triangle
        /// which is the two longer sides are same if the three side can make a triangle
        /// </summary>
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

        /// <summary>
        /// If the three side can make a triangle,
        /// The only situation that can make a Scalene Triangle
        /// which is the three side are all different 
        /// </summary>
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
