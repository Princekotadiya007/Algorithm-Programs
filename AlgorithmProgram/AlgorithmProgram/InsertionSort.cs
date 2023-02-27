using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class InsertionSort
    {
        public static void Sort(string[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                string key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }
        public void sorting()
        {
            Console.WriteLine("Enter a list of words separated by spaces:");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            InsertionSort.Sort(words);

            Console.WriteLine("Sorted List:");
            foreach (string word in words)
            {
                Console.WriteLine(word + " ");
            }
        }
    }
}
