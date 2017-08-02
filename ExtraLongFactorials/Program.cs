using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        var result = Factorial(n);
        Console.WriteLine(result);
    }

    private static Dictionary<int, BigInteger> _memo = new Dictionary<int, BigInteger>();

    private static BigInteger Factorial(int n)
    {
        if (n == 1)
            return 1;
        if (!_memo.ContainsKey(n))
            _memo[n] = Factorial(n - 1) * n;
        return _memo[n];
    }
}
