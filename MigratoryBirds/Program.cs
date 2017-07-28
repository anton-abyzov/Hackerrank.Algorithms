using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int migratoryBirds(int n, int[] ar)
    {
        var dict = new Dictionary<int, int>();
        for(var i = 0;i<n;i++)
        {
            if (dict.ContainsKey(ar[i]))
                dict[ar[i]]++;
            else
            {
                dict.Add(ar[i], 1);
            }
        }
        var mostOften = 0;
        var mostOftenIndex = 0;
        foreach (var i in dict)
        {
            if (i.Value < mostOften) continue;
            if (i.Value == mostOften)
            {
                mostOftenIndex = Math.Min(mostOftenIndex, i.Key);
            }
            else
            {
                mostOften = i.Value;
                mostOftenIndex = i.Key;
            }
        }
        return mostOftenIndex;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }

    //static void Main(String[] args)
    //{
    //    var FileStream = new StreamReader("seed_data.txt");
    //    int n = Convert.ToInt32(FileStream.ReadLine());
    //    string[] ar_temp = FileStream.ReadLine().Split(' ');
    //    int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
    //    int result = migratoryBirds(n, ar);
    //    Console.WriteLine(result);
    //}
}
