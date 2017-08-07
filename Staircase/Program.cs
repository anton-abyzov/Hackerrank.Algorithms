using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (var i = n - 1; i >= 0; i--)
        {
            var ident = string.Join("", Enumerable.Repeat(" ", i));
            var body = string.Join("", Enumerable.Repeat("#", n - i));
            Console.WriteLine(ident + body);
        }
    }
}
