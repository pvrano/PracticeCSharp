using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    public class CountDuplicateLetters
    {
        public static void Main(String[] args)
        {
            String sentence = "this is a repeat type word sentence and I just entered 2346 this is";

            Dictionary<char, int> countLetter = countingLetters(sentence);
            Console.WriteLine("Here is the number of time a letter occured");
            foreach (var pair in countLetter)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        static Dictionary<char, int> countingLetters(string sentence)
        {
            Dictionary<char, int> countLetter = new Dictionary<char, int>();
            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    char lowercaseChar = char.ToLower(c);
                    if (countLetter.ContainsKey(lowercaseChar))
                    {
                        countLetter[lowercaseChar]++;
                    }
                    else
                    {
                        countLetter[lowercaseChar] = 1;
                    }
                }

            }
            return countLetter;



        }
    }
}
