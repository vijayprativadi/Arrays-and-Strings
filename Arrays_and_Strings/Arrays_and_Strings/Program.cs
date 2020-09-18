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
            int sum = 10;

            ArrayImplementations.FindPairForGivenSumArray(arr, sum);

            Console.ReadKey();
        }
    }
}
