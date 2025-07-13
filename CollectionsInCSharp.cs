using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    public class PlayingWithCollections
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<string>> notes = new Dictionary<string, List<string>>();
            notes.Add("Active", new List<string> { "go shopping", "dry vegetables" });

            Console.WriteLine(notes);

        }
    }

}
