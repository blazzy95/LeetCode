using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 852. Peak Index in a Mountain Array
/// </summary>

namespace ConsoleApp4
{
    class peakIndexInMountainArray
    {
        public static void Main(String[] a)
        {
            int[] arr = new int[] { 1,2,1,3,0,2,4,2,1 };
            Console.WriteLine(peakIndexInMountain(arr));
            Console.Read();
        }

        public static int peakIndexInMountain(int[] input)
        {
            return recursive(input, 0, input.Length - 1, input.Length);
        }

        public static int recursive(int[] input, int start, int end, int n)
        {
            int mid = (start + end) / 2;
            if ((mid == 0 || input[mid - 1] <= input[mid]) && (mid == n - 1 || input[mid + 1] <= input[mid]))
                return mid;

            else if (mid > 0 && input[mid - 1] > input[mid])
                return recursive(input,start , (mid - 1), n);

            else
                return recursive(input, (mid + 1), end, n);
        }
    }
}
