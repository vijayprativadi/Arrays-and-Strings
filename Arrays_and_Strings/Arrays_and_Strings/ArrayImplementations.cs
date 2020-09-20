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

        public static int[] SmallestDifferenceofAnArray(int[] arr1)
        {
            int[] result = new int[0];
            Array.Sort(arr1);
            int diff = arr1[1] - arr1[0];// = int.MaxValue;//i don't think we need to initialize to max or anything
            result = new int[2] { arr1[1], arr1[0] };

            if (arr1.Length > 0)
            {
                for (int i = 2; i < arr1.Length; i++)
                { 
                    int currentdiff = arr1[i] - arr1[i - 1];

                    if (currentdiff < diff)
                    {
                        result = new int[2] { arr1[i], arr1[i - 1] };
                        diff = currentdiff;
                    }
                }
            }
            return result;
        }

        public static int[] SmallestDifferenceofArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[0];
            Array.Sort(arr1);
            Array.Sort(arr2);
            int diff = int.MaxValue;
            int currentdiff = 0;
            if (arr1.Length > 0 && arr1.Length > 0)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] < arr2[j])
                        {
                            currentdiff = arr2[j] - arr1[i];
                        }
                        else
                        {
                            currentdiff = arr1[i] - arr2[j];
                        }

                        if (currentdiff < diff)
                        {
                            result = new int[2] { arr1[i], arr2[j] };
                            diff = currentdiff;
                        }

                    }
                }
            }
            return result;
        }

        public static int?[]SubArraySort(int[] arr)
        {
            int? start = null;
            int? end = null;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] < arr[i] && start == null)
                {
                    start = i;

                }

                if (arr[i + 1] < arr[i] && start != null)
                {
                    end = i + 1;
                }
            }

            return new int?[] { start, end };
        }

        public static List<List<int>> Subset(int[] arr)
        {
            List<List<int>> result = new List<List<int>>();

            GetAllList(arr, new List<int>(), result, 0);

            return result;
        }

        public static void GetAllList(int[] arr, List<int> build, List<List<int>> result, int startIndex)
        {
            result.Add(build);

            for (int i = startIndex; i < arr.Length; i++)
            {
                var newItem = new List<int>(build);
                newItem.Add(arr[i]);

                GetAllList(arr, newItem, result, i + 1);
            }
        }

        public static int SubarraySum(int[] nums, int k)
        {
            if (nums.Length == 0) return 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            map.Add(0, 1);
            int result = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (map.ContainsKey(sum - k))
                    result += map[sum - k];
                if (map.ContainsKey(sum))
                    map[sum]++;
                else
                    map.Add(sum, 1);


            }
            return result;
        }

    }
}

