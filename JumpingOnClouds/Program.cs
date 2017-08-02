using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp, Int32.Parse);
        var index = 0;
        var E = 100;
        do
        {
            if (c[index] == 1)
            {
                E -= 2;
            }
            index = (index + k) % n;
            E -= 1;
        } while (index != 0);
        Console.WriteLine(E);
    }
}
