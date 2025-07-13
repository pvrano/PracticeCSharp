using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    public class StringReverse
    {
        

        

        public string reverse(string nameToReverse)
        {
            string reversedName = "";
            for (int i = nameToReverse.Length - 1; i >= 0; i--)
            {
                reversedName = reversedName + nameToReverse[i];
            }


            return reversedName;
        }
    }
}
