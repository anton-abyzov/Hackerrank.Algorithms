using System;
using System.Numerics;
class RecursiveExercises
{
    static void Main(string[] args)
    {
        var x = int.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine(Solve(x, n));
    }

    static int Solve(int x, int n)
    {
        var dp = new int[x + 1];
        dp[0] = 1;
        for (int i = 1; i <= x; i++)
        {
            var num = (BigInteger)Math.Pow(i, n);
            if (num > x)
            {
                break;
            }
            for (int j = x; j >= num; j--)
            {
                if (dp[(int)(j - num)] != 0)
                {
                    dp[j] += dp[(int)(j - num)];
                }
            }
        }
        return dp[x];
    }
}