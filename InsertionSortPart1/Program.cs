using System;
using System.Threading;

namespace InsertionSortPart1
{

    class Program
    {

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            var elemToInsert = arr[arr.Length - 1];
            int i = 0;
            for (i = arr.Length - 2; i >= 0 && arr[i] > elemToInsert; i--)
            {
                arr[i + 1] = arr[i];
                Array.ForEach(arr, (x) => Console.Write(x + " "));
                Console.WriteLine();
            }
            arr[i + 1] = elemToInsert;
            Array.ForEach(arr, (x) => Console.Write(x + " "));
        }

    }
}