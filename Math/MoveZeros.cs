using System;

/// <summary>
/// 283. Move Zeroes
/// </summary>

namespace ConsoleApp4
{
    class MoveZeros
    {
        private static void MoveZeroes(int[] arr)
        {
            int i = 0,j=1;
            while(j<arr.Length)
            {
                if (arr[i] == 0 && arr[j] == 0)
                    j++;
                else if (arr[i] == 0)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    i++;
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
            }
        }
    }
}
