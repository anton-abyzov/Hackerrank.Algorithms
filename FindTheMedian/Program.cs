using System;
using System.Linq;

namespace FindTheMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var values = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(values, int.Parse);
            arr = arr.OrderBy(x => x).ToArray();
            var median = arr.Length / 2;
            Console.WriteLine(arr[median]);
        }
    }
}