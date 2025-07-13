using  NUnit.Framework;
namespace PracticeOops.Tests
{
    public class ArrayPracticeTest
    {
        ArrayPractice arrayPracticeObject = new ArrayPractice();
        [Test]
        public void TestNumbersArray()
        {
            // Act
            arrayPracticeObject.numbersArray();

            // Assert
            Assert.Pass("The numbersArray method executed successfully.");


        }

        [Test]
        public void TestReverseArray()
        {
            // Arrange
            string[] names = { "John", "Jane", "Doe" };
            // Act
            string[] reversedNames = arrayPracticeObject.reverseArray(names);
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
            int sum = arrayPracticeObject.AddNumbersOfArray(numbers);
            Console.WriteLine($"Sum of array: {sum}");

            // Assert
            Assert.That(sum, Is.EqualTo(15), "The sum of the array should be 15.");
            TestContext.WriteLine($"The test passed as the sum is 15");
        }

        [Test, Order(1)]
        public void TestPrintUniqueElements()
        {
            int[] numbers = { 1, 1, 2, 3, 3, 4, 5, 5, 5, 4, 6, 6 };
            List<int> outputListOfUniqueElements = arrayPracticeObject.printUniqueElements(numbers);
            foreach (int number in outputListOfUniqueElements)
            {
                Console.WriteLine(number);
            }
            Assert.That(outputListOfUniqueElements, Is.EqualTo(new List<int> { 1, 2, 3, 4, 5, 6 }));
            TestContext.WriteLine("Test Passed as the list contains only unique elements");

        }
    }
}