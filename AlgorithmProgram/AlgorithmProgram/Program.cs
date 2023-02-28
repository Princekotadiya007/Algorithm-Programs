using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Algorithm program");
                Console.WriteLine("\n1.PermutationsOfString,\n2.InsertionSort,\n3.Bubblesort,\n4.Anagram, \n5.MergeSort,\n6.PrimeNumber");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        PermutationsOfString permutations = new PermutationsOfString();
                        permutations.Driver();
                        break;
                    case 2:
                        InsertionSort sortsort = new InsertionSort();
                        sortsort.sorting();
                        break;
                    case 3:
                        BubbleSort bubble = new BubbleSort();
                        bubble.BubbleSorting();
                        break;
                    case 4:
                        Anagram anagram = new Anagram();
                        anagram.Drivers();
                        break;
                    case 5:
                        MergeSort mergeSort = new MergeSort();
                        mergeSort.DriverControl();
                        break;
                    case 6:
                        PrimeNumber prime = new PrimeNumber();
                        prime.Primes();
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}
