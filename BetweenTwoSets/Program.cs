using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int getTotalX(int[] a, int[] b)
    {
        Array.Sort(a);
        Array.Sort(b);
        var diff = b.Min() - a.Max();
        if (diff < 0)
            return 0;
        var counter = 0;
        for (int x = a.Max(); x <= b.Min(); x++)
        {
            bool satisfies = true;
            for (int j = 0; j < a.Length; j++)
            {
                if (x % a[j] != 0)
                {
                    satisfies = false;
                    break;
                }
            }
            for (int j = 0; j < b.Length; j++)
            {
                if (b[j] % x != 0)
                {
                    satisfies = false;
                    break;
                }
            }
            if (satisfies)
                counter++;
        }
        return counter;
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp, Int32.Parse);
        int total = getTotalX(a, b);
        Console.WriteLine(total);
    }
}
