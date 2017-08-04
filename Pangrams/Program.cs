using System;
using System.Collections.Generic;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var ch in s)
            {
                if (char.IsLetter(ch) && !set.Contains(ch.ToString()))
                {
                    set.Add(ch.ToString());
                }
                if (set.Count == 26)
                {
                    Console.WriteLine("pangram");
                    return;
                }
            }
            Console.WriteLine("not pangram");
        }
    }
}