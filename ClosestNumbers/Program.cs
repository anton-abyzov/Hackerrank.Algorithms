using System;

namespace ClosestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var line = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(line, int.Parse);
            Array.Sort(arr);
            var minDiff = arr[1] - arr[0];
            for (int i = 2; i < arr.Length; i++)
            {
                minDiff = Math.Min(minDiff, Math.Abs(arr[i] - arr[i - 1]));
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - arr[i - 1]) == minDiff)
                {
                    Console.Write(arr[i - 1] + " " + arr[i] + " ");
                }
            }
        }
    }
}