using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static long getWays(long money, long[] costs)
    {
        var changeArray = new int[money];
        changeArray[0] = 1;
        for (int cost = 0; cost < costs.Length; cost++)
        {
            for (var i = 1; i < money; i++)
            {
                //changeArray[i] = changeArray[i - 1] + 
                }
        }

    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        long[] c = Array.ConvertAll(c_temp, Int64.Parse);
        // Print the number of ways of making change for 'n' units using coins having the values given by 'c'
        long ways = getWays(n, c);

    }
}
