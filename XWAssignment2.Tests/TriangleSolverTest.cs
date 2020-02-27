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
        /// This is the first situation that cannot form a triangle,
        /// which is the biggest number is greater than sum of the other two numbers
        /// </summary>
        [Test]
        public void Analyze_Given1And2And4_ResultIsNo()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(1, 2, 4);

            //Assert
            Assert.AreEqual("No, the numbers cannot form a triangle", result);
        }

        /// <summary>
        /// This is the second situation that cannot form a triangle
        /// which is the biggest number equals to sum of the other two numbers
        /// </summary>
        [Test]
        public void Analyze_Given4And2And2_ResultIsNo()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(4, 2, 2);

            //Assert
            Assert.AreEqual("No, the numbers cannot form a triangle", result);
        }

        /// <summary>
        /// If the three numbers can form a triangle,
        /// This is the only situation that can form a Equilateral Triangle
        /// which is the three numbers are all same
        /// </summary>
        [Test]
        public void Analyze_Given2And2And2_ResultIsYesEquilateralTriangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(2, 2, 2);

            //Assert
            Assert.AreEqual("Yes, the numbers can form a equilateral triangle", result);
        }

        /// <summary>
        /// If the three numbers can form a triangle,
        /// This is the first situation that can form a Isosceles Triangle
        /// which is the two smaller numbers are same
        /// </summary>
        [Test]
        public void Analyze_Given3And2And2_ResultIsYesIsoscelesTriangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(3, 2, 2);

            //Assert
            Assert.AreEqual("Yes, the numbers can form a isosceles triangle", result);
        }

        /// <summary>
        /// If the three numbers can form a triangle,
        /// This is the second situation that can form a Isosceles Triangle
        /// which is the two bigger numbers are same
        /// </summary>
        [Test]
        public void Analyze_Given2And1And2_ResultIsYesIsoscelesTriangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(2, 1, 2);

            //Assert
            Assert.AreEqual("Yes, the numbers can form a isosceles triangle", result);
        }

        /// <summary>
        /// If the three numbers can form a triangle,
        /// This is the only situation that can form a Scalene Triangle
        /// which is the three numbers are all different 
        /// </summary>
        [Test]
        public void Analyze_Given24And16And20_ResultIsYesScaleneTriangle()
        {
            //Arrange
            string result;

            //Act
            result = TriangleSolver.Analyze(24, 16, 20);

            //Assert
            Assert.AreEqual("Yes, the numbers can form a scalene triangle", result);
        }
    }
}
