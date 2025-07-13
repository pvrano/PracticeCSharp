using NUnit.Framework;
using System;

namespace PracticeOops.Tests
{
    [TestFixture]
    public class BubbleSortTest
    {
        [Test]
        public void TestBubbleSort()
        {
            // Arrange
            var sorter = new BubbleSortProgram();
            var unsorted = new int[] { 5, 2, 9, 1, 5, 6 };
            var expected = new int[] { 1, 2, 5, 5, 6, 9 };

            // Act
            sorter.sort(unsorted);

            // Assert
            Assert.That(unsorted, Is.EqualTo(expected));
        }
    }
}