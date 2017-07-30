using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] calories_temp = Console.ReadLine().Split(' ');
        int[] calories = Array.ConvertAll(calories_temp, Int32.Parse);
        calories = calories.OrderByDescending(x => x).ToArray();
        var miles = Enumerable.Range(0, n).Sum(x => Math.Pow(2, x) * calories[x]);
        Console.WriteLine(miles);
    }
}
