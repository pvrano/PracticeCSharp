using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    public class HowManyTimes
    {

        public static void Main(String[] args)
        {
            string sentence = "Hi My Name is Priyanka and I am 30 years old";
            int sum = countAlphabets(sentence);
            Console.WriteLine("total number of alphabets in this sentence are " + sum);
            HowManyTimes obj = new HowManyTimes();
            int summ = obj.countEverything(sentence);
            Console.WriteLine("Total number when counting the spaces then it is " + summ);

        }

        static int countAlphabets(string sntnce)
        {
            int count = 0;
            foreach (char c in sntnce)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }

            }
            return count;
        }

        public int countEverything(string sntnce)
        {
            int summ = 0;
            foreach (char ch in sntnce)
            {
                if (char.IsLetter(ch) || ch == ' ')
                {
                    summ++;
                }

            }
            return summ;
        }


    }
}
