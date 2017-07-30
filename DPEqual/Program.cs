using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= T; i++)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            Array.Sort(arr);
            int num_operation = 0;
            for (int j = N - 1; j > 0; j--)
            {
                int diff = arr[j] - arr[0];
                num_operation += diff / 5 + (diff % 5) / 2 + ((diff % 5) % 2) / 1;
            }
            Console.WriteLine(num_operation);
        }
    }
}