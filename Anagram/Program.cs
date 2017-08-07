using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{

    static int anagram(string s)
    {
        if (s.Length % 2 != 0)
            return -1;
        var s1 = s.Substring(0, s.Length / 2);
        var s2 = s.Substring(s.Length / 2, s.Length / 2);
        
        var counter = 0;
        foreach (var ch in s1)
        {
            if (!s2.Contains(ch))
                counter++;
            if (s2.Contains(ch))
            {
                var ind = s2.IndexOf(ch);
                s2 = s2.Remove(ind, 1);
            }
        }
        return counter;
    }

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string s = Console.ReadLine();
            int result = anagram(s);
            Console.WriteLine(result);
        }
    }
}
