using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        var counter = 1;
        foreach (var character in s)
        {
            if (character >= 65 && character <= 90)
                counter++;
        }
        Console.WriteLine(counter);
    }
}
