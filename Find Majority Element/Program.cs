using System;
using System.Collections.Generic;

namespace Find_Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 8, 3, 2, 2, 4, 2, 2 };
            Console.WriteLine(MajorityElement(arr));
        }

        public static int MajorityElement(int[] arr)
        {
            int len = arr.Length;
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < len; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]]++;
                }
                else
                {
                    dic.Add(arr[i], 1);
                }
            }

            foreach (var item in dic)
            {
                if (item.Value> len / 2)
                    return item.Key;
            }

            return -1;
        }
    }
}
