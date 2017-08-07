using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        int n = Convert.ToInt32(Console.ReadLine());
        HashSet<int> weightedArray = ParseStr(s);
        for (int a0 = 0; a0 < n; a0++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(weightedArray.Contains(x) ? "Yes" : "No");
        }
    }

    private static HashSet<int> ParseStr(string input)
    {
        var weightedArr = new HashSet<int>();
        
        var i = 0;
        string seq = "";
        do
        {
            var weight = 0;

            if (input[i] != seq.Distinct().FirstOrDefault())
            {
                seq = input[i].ToString();
            }
            else
            {
                seq += input[i];
            }
            foreach (var ch in seq)
            {
                weight += ch - 'a' + 1;
            }
            weightedArr.Add(weight);
        } while (++i < input.Length);
        return weightedArr;
    }
}
