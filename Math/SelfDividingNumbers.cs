using System;
using System.Collections.Generic;


/// <summary>
/// 728. Self Dividing Numbers
/// </summary>

namespace ConsoleApp4
{
    class SelfDividingNumbers
    {
        private static IList<int> SelfDividingNumber(int left, int right)
        {
            bool flag = true;
            List<int> list = new List<int>();
            for (; left <= right; left++)
            {
                string l = left.ToString();
                if (l.Contains("0"))
                    continue;
                for(int i =0;i<l.Length;i++)
                {
                    if (left%Int32.Parse(l[i].ToString())!=0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    list.Add(left);
                }
                flag = true;

            }
            return list;
        }
    }
}
