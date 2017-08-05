using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{

    static void Main(String[] args)
    {
        int len = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        var distinctChars = s.ToCharArray().Distinct().ToArray();
        var maxStr = "";
        if (IsCorrectString(s))
            maxStr = s;
        for (int i = 0; i < distinctChars.Length; i++)
        {
            for (int j = 0; j < distinctChars.Length; j++)
            {
                if (j == i) continue;
                var strAfterRemove = ReplaceIfNotChars(s, distinctChars[i], distinctChars[j]);
                if (IsCorrectString(strAfterRemove))
                {
                    maxStr = strAfterRemove.Length > maxStr.Length ? strAfterRemove : maxStr;
                }
            }
        }
        Console.WriteLine(maxStr.Length);
    }

    static bool IsCorrectString(string input)
    {
        if (input.Length < 2)
            return false;
        if (input.ToCharArray().Distinct().Count() != 2)
            return false;
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
                return false;
        }
        return true;
    }

    static string ReplaceIfNotChars(string input, char char1, char char2)
    {
        var result = "";
        input = Regex.Replace(input, "[^" + char1 + char2 + "]", "");
        return input;
    }
}
