using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{
    internal class BubbleSortProgram
    {
        public static void Main(String[] args)
        {
            int[] arr = { 34, 56, 22, 11, 93, 54, 62, 56 };
            Console.WriteLine("Original Array: ");
            printArry(arr);
            bubbleSortAlgorithm(arr);
            Console.WriteLine("sorted array");
            printArry(arr);

        }

        static void bubbleSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for(int i =0;i<n-1;i++)
            {
                for(int j=0;j<n-i-1;j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            
        }

        static void printArry(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
    }
}
