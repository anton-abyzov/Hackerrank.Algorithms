using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] unsorted = new string[n];
        for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
        {
            var str = Console.ReadLine();
            unsorted[unsorted_i] = str;
        }

        Array.Sort(unsorted, (string a, string b) =>
        {
            if (a.Length == b.Length)
                return String.CompareOrdinal(a, b);
            return a.Length - b.Length;
        });
        foreach (var item in unsorted)
        {
            Console.WriteLine(item);
        }
    }
}

