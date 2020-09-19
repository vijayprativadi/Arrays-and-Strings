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
            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int[] seq = { 7, 5, 1};
            int sum = 10;

            ArrayImplementations.FindPairForGivenSumArray(arr, sum);

            Console.WriteLine("Is Sequence Valid: " + ArrayImplementations.ValidateSequence(arr, seq));

            Console.WriteLine("Is Monotonic Array: " + ArrayImplementations.MonotonicArray(new int[] { 1, 2, 3, 0}));


            Console.ReadKey();
        }
    }
}
