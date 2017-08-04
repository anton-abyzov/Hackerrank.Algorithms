using System;

namespace CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var lines = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(lines, int.Parse);
            var countingArr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                countingArr[arr[i]]++;
            }
            //for (int i = 1; i < countingArr.Length; i++)
            //{
            //    countingArr[i] += countingArr[i - 1];
            //}
            for (int i = 0; i < countingArr.Length; i++)
            {
                Console.Write(countingArr[i] + " ");
            }
            var result = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    result[countingArr[arr[i]]-1] = arr[i];
            //    result[countingArr[arr[i]]-1]--;
            //}

        }
    }
}