using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string[] tokens_x = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(tokens_x[0]);
            int y = Convert.ToInt32(tokens_x[1]);
            int z = Convert.ToInt32(tokens_x[2]);
            var result = Math.Abs(x - z).CompareTo(Math.Abs(y - z)); // 1 - if follows the previous value
            switch (result)
            {
                case 0:
                    Console.WriteLine("Mouse C");
                    break;
                case 1:
                    Console.WriteLine("Cat B");
                    break;
                case -1:
                    Console.WriteLine("Cat A");
                    break;
            }
        }
    }
}
