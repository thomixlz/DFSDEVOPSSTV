using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitsTests
{
    [TestClass]
    internal class MathOperationsTest
    {
        [TestMethod]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange
            var operations = new MathOperations();
            int numberOne = 5;
            int numberTwo = 3;

            // Act
            var result = operations.Add(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Divide_ShouldReturnDivisionOfTwoNumbers()
        {
            // Arrange
            var operations = new MathOperations();
            int numberOne = 10;
            int numberTwo = 2;

            // Act
            var result = operations.Divide(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(5f, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Second parameter can't be equal to zero")]
        public void Divide_ShouldThrowArgumentExceptionWhenDividedByZero()
        {
            // Arrange
            var operations = new MathOperations();
            int numberOne = 10;
            int numberTwo = 0;

            // Act
            operations.Divide(numberOne, numberTwo);
        }

        [TestMethod]
        public void GetOddNumbers_ShouldReturnOddNumbersUpToLimit()
        {
            // Arrange
            var operations = new MathOperations();
            int limit = 5;

            // Act
            var result = operations.GetOddNumbers(limit);

            // Assert
            var expected = new List<int> { 1, 3, 5 };
            CollectionAssert.AreEqual(expected, result.ToList());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Limit argument can't be negative")]
        public void GetOddNumbers_ShouldThrowArgumentExceptionForNegativeLimit()
        {
            // Arrange
            var operations = new MathOperations();
            int limit = -1;

            // Act
            operations.GetOddNumbers(limit);
        }
    }
}