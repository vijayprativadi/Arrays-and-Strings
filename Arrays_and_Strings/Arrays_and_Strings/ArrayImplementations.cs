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

        public static bool ValidateSequence(int[] arr, int[] seq)
        {
            int arrIdx = 0;
            int seqIdx = 0;
            while (arrIdx < arr.Length - 1 && seqIdx < arr.Length -1)
            {
                if (arr[arrIdx] == seq[seqIdx])
                {
                    seqIdx++;
                }
                arrIdx++;
            }
            return seqIdx == seq.Length;
        }

        public static bool MonotonicArray(int[] arr)
        {
            bool isMonotonic = true;
            string order = string.Empty;
            if (arr.Length > 0)
            {
                if (arr[0] > arr[1])
                {
                    order = "DESC";
                }
                else
                {
                    order = "ASC";
                }

                for (int i = 1; i < arr.Length - 1; i++)
                {
                    if (order == "ASC")
                    {
                        if (arr[i + 1] < arr[i])
                        {
                            isMonotonic = false;
                            break;
                        }
                    }
                    else
                    {
                        if (arr[i + 1] > arr[i])
                        {
                            isMonotonic = false;
                            break;
                        }
                    }
                }
            }

            return isMonotonic;
        }

    }
}

