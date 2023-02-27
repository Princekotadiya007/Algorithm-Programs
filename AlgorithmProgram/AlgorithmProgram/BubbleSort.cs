using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class BubbleSort
    {
        public static int[] Sorting(int[] list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = 0; j < list.Length - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            return list;
        }
        public void BubbleSorting()
        {
            Console.WriteLine("Enter a list of integers (separated by spaces):");

            // Read in the list of integers
            string input = Console.ReadLine();
            string[] stringList = input.Split(' ');
            int[] intList = new int[stringList.Length];

            for (int i = 0; i < stringList.Length; i++)
            {
                intList[i] = int.Parse(stringList[i]);
            }

            // Sort the list using the bubble sort algorithm
            int[] sortedList = BubbleSort.Sorting(intList);

            // Print the sorted list
            Console.WriteLine("Sorted list:");
            for (int i = 0; i < sortedList.Length; i++)
            {
                Console.Write(sortedList[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

