using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    public class ArrayPractice
    {


        public void numbersArray()
        {
            int[] numbers = { 2, 4, 2, 4 };

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        }

        public int AddNumbersOfArray(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = numbers[i] + sum;
            }
            return sum;

        }

        public string[] reverseArray(string[] names)
        {
            Array.Reverse(names);
            foreach (string name in names)
            {
                return string.Join(" ", names).Split(' ');
            }
            return Array.Empty<string>();
        }


    }
}

           




