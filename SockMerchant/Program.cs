using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int sockMerchant(int n, int[] ar)
    {
        var socksDictionary = new Dictionary<int, int>();
        for (var i = 0; i < ar.Length; i++)
        {
            if (socksDictionary.ContainsKey(ar[i]))
            {
                socksDictionary[ar[i]]++;
            }
            else
            {
                socksDictionary.Add(ar[i], 1);
            }
        }
        var looseCounter = 0;
        foreach (var item in socksDictionary)
        {
            looseCounter += item.Value / 2;
        }
        return looseCounter;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = sockMerchant(n, ar);
        Console.WriteLine(result);
    }
}
