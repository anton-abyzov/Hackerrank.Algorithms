using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);
        var min = arr.Sum() - arr.Max();
        var max = arr.Sum() - arr.Min();
        Console.WriteLine("{0} {1}", min, max);
    }
}
