using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    //static void Main(String[] args)
    //{
    //    var file = new StreamReader("seed_data.txt");
    //    string[] tokens_n = file.ReadLine().Split(' ');
    //    int n = Convert.ToInt32(tokens_n[0]);
    //    int k = Convert.ToInt32(tokens_n[1]);
    //    string[] x_temp = file.ReadLine().Split(' ');
    //    int[] houses = Array.ConvertAll(x_temp, Int32.Parse);
    //    LocateTransmitters(houses, k);
    //}

    private static void LocateTransmitters(int[] houses, int k)
    {
        Array.Sort(houses);
        Stack<int> transmitters = new Stack<int>();
        foreach (var house in houses)
        {
            if (transmitters.Any() && (transmitters.Peek() - k >= house || house <= transmitters.Peek() + k))
                continue;
            for (int cover = k; cover >= 0; cover--)
            {
                if (Array.BinarySearch(houses, house + cover) >= 0)
                {
                    transmitters.Push(house + cover);
                    break;
                }
            }
        }

        Console.WriteLine(transmitters.Count);
    }

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] x_temp = Console.ReadLine().Split(' ');
        int[] houses = Array.ConvertAll(x_temp, Int32.Parse);
        LocateTransmitters(houses, k);
    }
}
