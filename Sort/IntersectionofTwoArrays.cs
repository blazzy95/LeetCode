using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// 349. Intersection of Two Arrays
/// </summary>

namespace Sort
{
    class IntersectionofTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            foreach(int i in nums1)
            {
                set1.Add(i);
            }

            foreach(int i in nums2)
            {
                if (set1.Contains(i))
                    set2.Add(i);
            }

            return set2.ToArray<int>();

        }
    }
}
