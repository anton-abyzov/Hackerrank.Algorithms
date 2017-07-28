using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int[] getRecord(int[] s)
    {
        var bestRecord = s[0];
        var worstRecord = s[0];
        var bestRecCounter = 0;
        var worstRecCounter = 0;
        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] > bestRecord)
            {
                bestRecCounter++;
                bestRecord = s[i];
            }
            if (s[i] < worstRecord)
            {
                worstRecCounter++;
                worstRecord = s[i];
            }
        }
        return new int[]{bestRecCounter, worstRecCounter};
    }
 
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp, Int32.Parse);
        int[] result = getRecord(s);
        Console.WriteLine(String.Join(" ", result));
    }
}
