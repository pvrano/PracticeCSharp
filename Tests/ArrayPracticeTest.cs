using  NUnit.Framework;
namespace PracticeOops.Tests
{
    public class ArrayPracticeTest
    {
        ArrayPractice arrayPractice = new ArrayPractice();
        [Test]
        public void TestNumbersArray()
        {
            // Act
            arrayPractice.numbersArray();

            // Assert
            Assert.Pass("The numbersArray method executed successfully.");


        }

        [Test]
        public void TestReverseArray()
        {
            // Arrange
            string[] names = { "John", "Jane", "Doe" };
            // Act
            string[] reversedNames = arrayPractice.reverseArray(names);
            foreach (string name in reversedNames)
            {
                Console.WriteLine(name);
            }

            // Assert
            Assert.That(reversedNames, Is.EqualTo(new[] { "Doe", "Jane", "John" }));


        }

        [Test, Category("Sum")]
        public void TestAddNumbersOfArray()
        {
            TestContext.WriteLine("Testing AddNumbersOfArray method...");
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            TestContext.WriteLine($"Input array: {string.Join(", ", numbers)}");
            // Act
            int sum = arrayPractice.AddNumbersOfArray(numbers);
            Console.WriteLine($"Sum of array: {sum}");

            // Assert
            Assert.That(sum, Is.EqualTo(15), "The sum of the array should be 15.");
            TestContext.WriteLine($"The test passed as the sum is 15");
        }
    }
}