using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    public class DuplicateLetters
    {
        

        public  Dictionary<char, int> countLetters(string sentence)
        {
            Dictionary<char, int> countLetter = new Dictionary<char, int>();
            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                {
                    countLetter[char.ToLower(c)] = 0;
                }

            }
            foreach (char c in sentence)
            {
                
                
                    char lowercaseChar = char.ToLower(c);
                if (countLetter.ContainsKey(lowercaseChar))
                {
                    countLetter[lowercaseChar]++;
                }

            }
            return countLetter;



        }
    }
}
