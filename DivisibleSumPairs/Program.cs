using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        var counter = 0;
        for(var i = 0; i < n; i++)
        {
            for (var j = i+1; j < n; j++)
            {
                if (i == j) continue;
                if ((ar[i] + ar[j]) % k == 0)
                {
                    counter++;
                }
            }
        }
        return counter;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = divisibleSumPairs(n, k, ar);
        Console.WriteLine(result);
    }
}
