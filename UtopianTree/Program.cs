using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var result = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    result *= 2;
                else
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
