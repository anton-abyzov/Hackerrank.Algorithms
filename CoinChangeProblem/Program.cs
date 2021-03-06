﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static long getWays(long money, long[] coins)
    {
        var changeArray = new long[money + 1];
        changeArray[0] = 1;
        foreach (var coin in coins)
        {
            for (var amount = 1; amount <= money; amount++)
            {
                if (amount >= coin)
                    changeArray[amount] +=  changeArray[amount - coin];
            }
        }
        return changeArray[money];
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
        Console.WriteLine(ways);
    }
}
