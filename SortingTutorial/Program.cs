using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        var v = Convert.ToInt32(Console.ReadLine());
        var n = Convert.ToInt32(Console.ReadLine());
        var line = Console.ReadLine().Split(' ');
        var array = Array.ConvertAll(line, int.Parse);
        var index = Array.BinarySearch(array, v);
        Console.WriteLine(index);
    }
}