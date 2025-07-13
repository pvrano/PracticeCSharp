using NUnit.Framework;

namespace PracticeOops.Tests
{
    [TestFixture]
    public class DuplicateLettersTest
    {
        [Test]
        public void TestDuplicateLetters()
        {
            DuplicateLetters duplicateLetters = new DuplicateLetters();
            String sentence = "this is a repeat type word sentence and I just entered 2346 this is";

            Dictionary<char, int> countLetter = duplicateLetters.countLetters(sentence);
            Console.WriteLine("Here is the number of time a letter occured");
            foreach (var pair in countLetter)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            Assert.That(countLetter['t'], Is.EqualTo(7));
        }
        
    }
}