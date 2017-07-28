using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(' ');
            var array = Array.ConvertAll(line, int.Parse);
            var maxElementCount = array.GroupBy(x => x).Max(x => x.Count());
            Console.WriteLine(n - maxElementCount);
        }
    }
} 