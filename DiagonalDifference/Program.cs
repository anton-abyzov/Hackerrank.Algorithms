using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for (int a_i = 0; a_i < n; a_i++)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
        }
        var diag1 = 0;
        var diag2 = 0;
        for (var i = 0; i < n; i++)
        {
            diag1 += a[i][i];
            diag2 += a[i][n - 1 - i];
        }
        Console.WriteLine(Math.Abs(diag1 - diag2));
    }
}
