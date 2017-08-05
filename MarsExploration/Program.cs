using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        var sosCount = S.Length / 3;
        var sosstring = "";
        for (int i = 0; i < sosCount; i++)
        {
            sosstring += "SOS";
        }
        var counter = 0;
        for (int i = 0; i < S.Length; i++)
        {
            if (S[i] != sosstring[i])
                counter++;
        }
        Console.WriteLine(counter);
    }
}
