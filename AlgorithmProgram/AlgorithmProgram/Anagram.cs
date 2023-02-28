using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Anagram
    {
        public bool CheckIfAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            // convert strings to character arrays and sort them
            char[] charArr1 = str1.ToLower().ToCharArray();
            char[] charArr2 = str2.ToLower().ToCharArray();
            Array.Sort(charArr1);
            Array.Sort(charArr2);

            // check if the sorted character arrays are equal
            return new string(charArr1) == new string(charArr2);
        }
        public void Drivers()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            bool areAnagrams = CheckIfAnagrams(str1, str2);

            if (areAnagrams)
            {
                Console.WriteLine("The two strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The two strings are not anagrams.");
            }
        }
    }
}
