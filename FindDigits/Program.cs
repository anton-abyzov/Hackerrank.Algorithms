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
            var x = n;
            var digits = new List<int>();
            while (x > 0)
            {
                digits.Add(x % 10);
                x = x / 10;
            }
            digits.Reverse();
            var counter = 0;
            foreach (var digit in digits)
            {
                if (digit == 0) continue;
                if (n % digit == 0)
                    counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
