using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class MergeSort
    {
        public void Merge(int[] array, int leftMostIndex, int middleIndex, int rightMostIndex)
        {
            //Calculating the size for the leftSubArray
            //left sub array's size will be Last Index - Middle Index + 1(+1 because we are starting from 0)
            int leftSubArraySize = middleIndex - leftMostIndex + 1;

            //Calculating the size for the rightSubArray
            int rightSubArraySize = rightMostIndex - middleIndex;

            //Creating temporary arrays for storing leftPart and rightPart
            int[] leftSubArray = new int[leftSubArraySize];
            int[] rightSubArray = new int[rightSubArraySize];

            //Inserting all the elements in their respective SubArrays
            for (int i1 = 0; i1 < leftSubArraySize; i1++)
            {
                //insert elements in leftSubArray from left most element
                leftSubArray[i1] = array[leftMostIndex + i1];
            }
            for (int j1 = 0; j1 < rightSubArraySize; j1++)
            {
                //insert elements in rightSubArray from middle + 1 element
                rightSubArray[j1] = array[middleIndex + 1 + j1];
            }
            //Creating variables i and j for storing the index positions for leftArray and rightArray
            //here i will be used to store index position in leftArray
            //and j will be used to store index position in rightArray
            int i = 0, j = 0;

            //declaring variable k
            //we will use k for indexing "array"
            int k = leftMostIndex;

            while (i < leftSubArraySize && j < rightSubArraySize)
            {
                //if element at i'th index of leftSubArray is less than element at j'th index of righSubArray
                if (leftSubArray[i] <= rightSubArray[j])
                {
                    //then place at k'th index of array the element at i'th index of leftSubArray
                    array[k] = leftSubArray[i];

                    //go to the next index of leftSubArray
                    i++;
                }
                //otherwise
                else
                {
                    //place at k'th index of array the element at j'th index of rightSubArray
                    array[k] = rightSubArray[j];

                    //go to the next index of rightSubArray
                    j++;
                }
                //go to the next index of "array"
                k++;
            }

            //Copy the remaining elements if any present in the respective SubArrays
            while (i < leftSubArraySize)
            {
                //put the remaining elements from leftSubArray into the array
                array[k] = leftSubArray[i];
                i++;
                k++;
            }
            while (j < rightSubArraySize)
            {
                //put the remaining elements from rightSubArray into the array
                array[k] = rightSubArray[j];
                j++;
                k++;
            }
        }
        //Sort method will divide the array till only 1 element is remaining in the array
        //then it will compare and merge then with the help of Merge method
        public void Sort(int[] array, int leftMostIndex, int rightMostIndex)
        {
            //If leftmost index is at the left and rightmost index is at the right side of the array
            if (leftMostIndex < rightMostIndex)
            {
                //find the middle index of the array
                int middleIndex = leftMostIndex + (rightMostIndex - leftMostIndex) / 2;

                //for sorting the left part/subpart of the array
                //left part starts from leftmost/1st index of array and end on the middle index
                Sort(array, leftMostIndex, middleIndex);

                //for sorting the right part/subpart of the array
                //right part starts from the next index of the middle index and end on the rightmost/last index
                Sort(array, middleIndex + 1, rightMostIndex);

                //After sorting is done we are going to merge two parts
                Merge(array, leftMostIndex, middleIndex, rightMostIndex);
            }

        }

        //Method for printing the elements we want to be sorted
        public void PrintArray(int[] sortArray)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                Console.Write(" " + sortArray[i]);
            }
            Console.WriteLine();
        }
        public void DriverControl()
        {
            MergeSort mergeSort = new MergeSort();
            Console.Write("Enter integer values one by one separated by spaces : ");
            //Taking input from user and storing it to strings array of type string
            string[] strings = Console.ReadLine().Split();

            int[] sortArray = new int[strings.Length];
            //Converting each string value in strings array to integer type and storing it to sortArray for further calculation
            for (int i = 0; i < strings.Length; i++)
            {
                sortArray[i] = Convert.ToInt32(strings[i]);
            }

            Console.Write("Array before sorting is : ");
            mergeSort.PrintArray(sortArray);

            //Passing (array, 1st element index as leftMostIndex, last index/ rightMostIndex) to Sort method
            mergeSort.Sort(sortArray, 0, sortArray.Length - 1);

            Console.Write("Array using Merge sort is : ");
            mergeSort.PrintArray(sortArray);
        }
    }
}
