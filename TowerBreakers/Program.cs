using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var file = new StreamReader("seed_data.txt");
        var t = Convert.ToInt32(file.ReadLine());
        for (int i = 0; i < t; i++)
        {
            var line = file.ReadLine().Split(' ');
            var n = Convert.ToInt32(line[0]);
            var m = Convert.ToInt32(line[1]);
            var towers = Enumerable.Repeat(m, n).ToArray();
            var dividers = GetDividers(m);
            //bool result = play(towers, dividers);
            Console.WriteLine(m == 1 ? 2 : n % 2 == 0 ? 2 : 1);
            //Console.WriteLine(result ? "1" : "2");
        }
    }

    private static bool play(int[] towers, int [] dividers)
    {
        if (towers.All(x => x == 1))
            return false;

        for (int i = 0; i < towers.Length; i++)
        {
            foreach (var divider in dividers)
            {
                var copyTowers = new int[towers.Length];
                towers.CopyTo(copyTowers, 0);
                if (copyTowers[i] - divider < 1)
                    continue;
                copyTowers[i] -= divider;
                var moveResult = play(copyTowers, dividers);
                if (!moveResult)
                    return true;
            }
        }
        return false;
    }

    private static int[] GetDividers(int number)
    {
        if (number == 2)
        {
            return new[] { 1, 2 };
        }
        if (number == 1)
        {
            return new[] { 1 };
        }
        var result = new List<int>();

        for (int i = 1; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                result.Add(i);
        }
        return result.ToArray();
    }


}