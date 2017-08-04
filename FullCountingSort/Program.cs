using System;
using System.Collections.Generic;
using System.Linq;

namespace FullCountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var dict = new Dictionary<int, Queue<string>>() ;
            var inputNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                var lines = Console.ReadLine().Split(' ');
                var index = Convert.ToInt32(lines[0]);
                var str = lines[1];
                if (i < n / 2)
                    str = "-";
                inputNumbers[i] = index;
                if (dict.ContainsKey(index))
                {
                    dict[index].Enqueue(str);
                }
                else
                {
                    var list = new Queue<string>();
                    list.Enqueue(str);
                    dict.Add(index, list);
                }
            }
            
            var countingArr = new int[101];
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                countingArr[inputNumbers[i]]++;
            }
            for (int i = 1; i < countingArr.Length; i++)
            {
                countingArr[i] += countingArr[i - 1];
            }
           
            var result = new int[n+1];
            for (int i = 0; i < n; i++)
            {
                result[countingArr[inputNumbers[i]]] = inputNumbers[i];
                countingArr[inputNumbers[i]]--;
            }

            for (int i = 1; i < result.Length; i++)
            {
                var dictElem = dict[result[i]].Dequeue();
                Console.Write(dictElem + " ");
            }
        }
    }
}