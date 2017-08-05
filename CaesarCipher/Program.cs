using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());

        var cipher = "";
        foreach (var ch in s)
        {
            if (ch >= 'a' && ch <= 'z')
            {
                var cipheredChar = (ch - 'a' + k) % 26 + 'a';
                cipher += (char)cipheredChar;
                continue;
            }
            if (ch >= 'A' && ch <= 'Z')
            {
                var cipheredChar = (ch - 'A' + k) % 26 + 'A';
                cipher += (char)cipheredChar;
                continue;
            }
            cipher += ch;
        }
        Console.WriteLine(cipher);
    }
}
