using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Strings
{
    public static class ArrayImplementations
    {
        public static void FindPairForGivenSumArray(int[] arr, int sum)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                // check if key is seen before
                if (list.Contains(sum - arr[i]))
                {
                    Console.WriteLine("Pair found is: " + list.Find(x => x == sum - arr[i]) + " and " + arr[i]);
                    return;
                }

                list.Add(arr[i]);
            }

            Console.WriteLine("Pair not found");
        }
    }
}
