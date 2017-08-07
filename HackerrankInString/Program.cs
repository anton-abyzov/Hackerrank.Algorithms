using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Regex.IsMatch(s, "h.*a.*c.*k.*e.*r.*r.*a.*n.*k.*") ? "YES" : "NO");
            // your code goes here
        }
    }
}
