using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

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
            var oneCharWeight = 0;

            if (input[i] != seq.Distinct().FirstOrDefault())
            {
                var firstCharOfSeq = input[i].ToString();
                var firstMatch = Regex.Match(input.Substring(i), firstCharOfSeq + "+");
                seq = firstMatch.Value;
                var firstMatchLength = firstMatch.Value.Length;
                i += firstMatchLength - 1;

            }
            else
            {
                seq += input[i];
            }
            for (int j = 0; j < seq.Length; j++)
            {
                oneCharWeight = seq[j] - 'a' + 1;
                weightedArr.Add(oneCharWeight * (j + 1));
            }
        } while (++i < input.Length);
        return weightedArr;
    }
}
