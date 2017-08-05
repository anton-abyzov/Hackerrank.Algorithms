using System;
using System.Threading;

namespace InsertionSortPart2
{

    class Program
    {

        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            for (int i = 1; i < arr.Length; i++)
            {
                InsertElement(arr, i);
            }
            
        }

        private static void InsertElement(int[] arr, int elemToInsertIndex)
        {
            int i = 0;
            var elemToInsert = arr[elemToInsertIndex];
            for (i = elemToInsertIndex - 1; i >= 0 && arr[i] > elemToInsert; i--)
            {
                arr[i + 1] = arr[i];
            }
            if (arr[i + 1] > elemToInsert)
                arr[i + 1] = elemToInsert;
            Array.ForEach(arr, (x) => Console.Write(x + " "));
            Console.WriteLine();
        }
    }
}