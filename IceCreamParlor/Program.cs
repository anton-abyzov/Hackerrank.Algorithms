using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IceCreamParlor
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var file = new StreamReader("seed_data.txt");
        //    var q = Convert.ToInt32(file.ReadLine());
        //    for (var i = 0; i < q; i++)
        //    {
        //        var money = Convert.ToInt32(file.ReadLine());
        //        var n = Convert.ToInt32(file.ReadLine());
        //        var line = file.ReadLine().Split(' ');
        //        var arr = Array.ConvertAll(line, int.Parse);
        //        Tuple<int, int>[] flavorCosts = new Tuple<int, int>[n];
        //        for (var j = 0; j < n; j++)
        //        {
        //            flavorCosts[j] = new Tuple<int, int>(j+1, arr[j]);
        //        }

        //        FindMatchingCost(flavorCosts, money);
        //    }
        //}

        static void Main(string[] args)
        {
            var q = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < q; i++)
            {
                var money = Convert.ToInt32(Console.ReadLine());
                var n = Convert.ToInt32(Console.ReadLine());
                var line = Console.ReadLine().Split(' ');
                var arr = Array.ConvertAll(line, int.Parse);
                Tuple<int, int>[] flavorCosts = new Tuple<int, int>[n];
                for (var j = 0; j < n; j++)
                {
                    flavorCosts[j] = new Tuple<int, int>(j + 1, arr[j]);
                }

                FindMatchingCost(flavorCosts, money);
            }
        }

        private static void FindMatchingCost(Tuple<int, int>[] flavorCosts, int money)
        {
            var orderedFlavors = flavorCosts.OrderBy(x => x.Item2).ToArray();
            
            for(var i = 0; i< orderedFlavors.Length; i++)
            {
                var cost = orderedFlavors[i];
                var matchingCostIndex = Array.BinarySearch(orderedFlavors, money - cost.Item2, new FlavorComparer());
                if (matchingCostIndex >= 0 && matchingCostIndex != i)
                {
                    var min = Math.Min(cost.Item1, orderedFlavors[matchingCostIndex].Item1);
                    var max = Math.Max(cost.Item1, orderedFlavors[matchingCostIndex].Item1);
                    Console.WriteLine("{0} {1}", min, max);
                    return;
                }
            }
        }

        public class FlavorComparer : IComparer<Tuple<int, int>>, IComparer
        {
            public int Compare(Tuple<int, int> x, Tuple<int, int> y)
            {
                return x.Item2.CompareTo(y.Item2);
            }
            
            public int Compare(object x, object y)
            {
                if (x is Tuple<int, int> && y is Tuple<int, int>)
                {
                    var a = x as Tuple<int, int>;
                    var b = x as Tuple<int, int>;
                    return a.Item2.CompareTo(b.Item2);
                }
                if (x is Tuple<int, int> && y is int)
                {
                    var a = x as Tuple<int, int>;
                    var b = (int)y;
                    return a.Item2.CompareTo(b);
                }
                return 0;
            }
        }
    }
}