using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitsTests
{
    [TestClass]
    public class CustomStackTest
    {
        [TestMethod]
        public void Push_ShouldAddValueToStack()
        {
            // Arrange
            var stack = new CustomStack();
            var value = 5;

            // Act
            stack.Push(value);

            // Assert
            Assert.AreEqual(1, stack.Count());
        }

        [TestMethod]
        public void Pop_ShouldReturnLastValueAndRemoveIt()
        {
            // Arrange
            var stack = new CustomStack();
            stack.Push(1);
            stack.Push(2);

            // Act
            var poppedValue = stack.Pop();

            // Assert
            Assert.AreEqual(2, poppedValue);
            Assert.AreEqual(1, stack.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(CustomStack.StackCantBeEmptyException))]
        public void Pop_ShouldThrowExceptionWhenStackIsEmpty()
        {
            // Arrange
            var stack = new CustomStack();

            // Act
            stack.Pop();
        }

        [TestMethod]
        public void Count_ShouldReturnCorrectNumberOfItems()
        {
            // Arrange
            var stack = new CustomStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Act
            var count = stack.Count();

            // Assert
            Assert.AreEqual(3, count);
        }
    }
}