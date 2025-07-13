using NUnit.Framework;
namespace PracticeOops.Tests
{
    [TestFixture]
    public class StringReverseTest
    {
        [Test]
        public void TestReverseTheName()
        {
            StringReverse stringReverser = new StringReverse();
            string nameToReverse = "Priya464654#@$@#nka";
            string finalOutPut = stringReverser.reverse(nameToReverse);
            Console.WriteLine(finalOutPut.ToLower());
            // Arrange
            string expectedOutput = "akn#@$@#456464ayirP";
            Assert.That(finalOutPut, Is.EqualTo(expectedOutput));
        }
    }
}