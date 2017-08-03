using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
class Solution
{

    static string timeConversion(string s)
    {
        var dateTime = DateTime.ParseExact(s, "hh:mm:sstt",CultureInfo.InvariantCulture);
        return dateTime.ToString("HH:mm:ss");
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
