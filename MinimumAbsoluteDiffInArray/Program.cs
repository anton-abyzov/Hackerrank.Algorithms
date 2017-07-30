using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        Array.Sort(a);
        var minDiff = Math.Abs(a[1] - a[0]);
        for (int i = 2; i < a.Length; i++)
        {
            if (Math.Abs(a[i] - a[i - 1]) < minDiff)
                minDiff = Math.Abs(a[i] - a[i - 1]);
        }
        Console.WriteLine(minDiff);
    }
}
