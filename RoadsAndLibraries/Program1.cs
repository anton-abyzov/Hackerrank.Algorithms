using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RoadAndLibraries
{
    static class Solution
    {
        //static void Main()
        //{
        //    var fileStream = new StreamReader("seed_data.txt");
        //    int q = Convert.ToInt32(fileStream.ReadLine());
        //    for (int a0 = 0; a0 < q; a0++)
        //    {
        //        string[] tokensN = fileStream.ReadLine().Split(' ');
        //        int n = Convert.ToInt32(tokensN[0]);
        //        int m = Convert.ToInt32(tokensN[1]);
        //        long costLib = Convert.ToInt64(tokensN[2]);
        //        long costRoad = Convert.ToInt64(tokensN[3]);

        //        var tuples = Enumerable.Range(0, m)
        //            .Select(p => Array.ConvertAll(fileStream.ReadLine().Split(' '), int.Parse))
        //            .Select(p1 => new Tuple<int, int>(p1[0], p1[1]))
        //            .ToArray();

        //        var result = CalculateCost(n, costLib, costRoad, tuples);
        //        Console.WriteLine(result);
        //    }
        //}

        private static long CalculateCost(int totalCities, long costLib, long costRoad, Tuple<int, int>[] tuples)
        {
            var cities = new Dictionary<int, List<int>>();

            if (costRoad >= costLib)
                return totalCities * costLib;

            foreach (var tuple in tuples)
            {
                if (cities.ContainsKey(tuple.Item1))
                    cities[tuple.Item1].Add(tuple.Item2);
                else
                    cities[tuple.Item1] = new List<int> { tuple.Item2 };

                if (cities.ContainsKey(tuple.Item2))
                    cities[tuple.Item2].Add(tuple.Item1);
                else
                    cities[tuple.Item2] = new List<int> { tuple.Item1 };
            }

            var visitedCities = new HashSet<int>();

            var neighbor = new Queue<int>();

            long result = 0;

            foreach (var i in Enumerable.Range(1, totalCities))
            {
                if (visitedCities.Contains(i))
                    continue;

                var totalCitiesInNeighbor = 0;

                neighbor.Enqueue(i);

                while (neighbor.Count > 0)
                {
                    var currentCity = neighbor.Dequeue();

                    if (visitedCities.Contains(currentCity))
                        continue;

                    totalCitiesInNeighbor++;
                    visitedCities.Add(currentCity);

                    if (!cities.ContainsKey(currentCity))
                        continue;

                    foreach (var iNeighbor in cities[currentCity])
                    {
                        if (visitedCities.Contains(iNeighbor))
                            continue;

                        neighbor.Enqueue(iNeighbor);
                    }
                }

                result += costLib + (totalCitiesInNeighbor - 1) * costRoad;
            }

            return result;
        }
    }
}