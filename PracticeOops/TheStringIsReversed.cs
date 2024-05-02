using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    internal class TheStringIsReversed
    {
        public static void Main(String[] args)
        {
            string nameToReverse = "Priya464654#@$@#nka";
            string finalOutPut = reverseTheName(nameToReverse);
            Console.WriteLine(finalOutPut.ToLower());
        }

        static string reverseTheName(string nameToReverse)
        {
            string reversedName = "";
            for(int i = nameToReverse.Length - 1; i >= 0; i--)
            {
                reversedName = reversedName + nameToReverse[i];
            }
            

            return reversedName;
        }
    }
}
