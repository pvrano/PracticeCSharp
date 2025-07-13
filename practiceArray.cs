using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    public class practiceArray
    {

        public void numbersArray()
        {
            int[] numbers = { 2, 4, 2, 4 };



            foreach (int i in numbers)
            {

                Console.WriteLine(i);



            }

        }
        public static void Main(string[] args)
        {
            practiceArray obj = new practiceArray();
            obj.numbersArray();



        }
    }
}
