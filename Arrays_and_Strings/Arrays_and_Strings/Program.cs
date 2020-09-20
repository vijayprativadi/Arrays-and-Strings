using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables/Constants

            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int[] seq = { 7, 5, 1};
            int sum = 10;

            ArrayImplementations.FindPairForGivenSumArray(arr, sum);

            Console.WriteLine("Is Sequence Valid: " + ArrayImplementations.ValidateSequence(arr, seq));

            Console.WriteLine("Is Monotonic Array: " + ArrayImplementations.MonotonicArray(new int[] { 1, 2, 3, 0}));

            int[] smallestDifferenceResult = ArrayImplementations.SmallestDifferenceofAnArray(new int[] { 100, 5, 10, 20, 28, 14 });
            StringBuilder sbSmallestDifference = new StringBuilder();
            String separatorForSmallestDifferenceResult = "";
            foreach (var item in smallestDifferenceResult)
            {
                sbSmallestDifference.Append(separatorForSmallestDifferenceResult);
                sbSmallestDifference.Append(item.ToString());
                separatorForSmallestDifferenceResult = ",";
            }
            Console.WriteLine("The smallest difference of a given array is: " + sbSmallestDifference.ToString());

            int[] smallestDifferenceofArraysResult = ArrayImplementations.SmallestDifferenceofArrays(new int[] { 100, 5, 10, 20, 28, 14 }, new int[] { 26, 134, 135, 15, 17 });
            StringBuilder sbSmallestDifferenceofArrays = new StringBuilder();
            String separatorForSmallestDifferenceofArraysResult = "";
            foreach (var item in smallestDifferenceofArraysResult)
            {
                sbSmallestDifferenceofArrays.Append(separatorForSmallestDifferenceofArraysResult);
                sbSmallestDifferenceofArrays.Append(item.ToString());
                separatorForSmallestDifferenceofArraysResult = ",";
            }
            Console.WriteLine("The smallest difference of two arrays is: " + sbSmallestDifferenceofArrays.ToString());

            int?[] subArraySortResult = ArrayImplementations.SubArraySort(new int[] { 2, 6, 4, 8, 10, 11, 9 });
            StringBuilder sbSubArraySort = new StringBuilder();
            String separatorForSubArraySort = "";
            foreach (var item in subArraySortResult)
            {
                sbSubArraySort.Append(separatorForSubArraySort);
                sbSubArraySort.Append(item.ToString());
                separatorForSubArraySort = ",";
            }
            Console.WriteLine("The Sub Array Sort starting and ending indexes are: " + sbSubArraySort.ToString());

            List<List<int>> subsetRecursive = ArrayImplementations.Subset(new int[] { 1, 2, 3});

            Console.ReadKey();
        }
    }
}
