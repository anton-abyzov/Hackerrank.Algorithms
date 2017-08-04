using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void partition(int[] ar)
    {
        var pivot = ar[0];
        var left = 0;
        var right = ar.Length - 1;
        var leftPart = new List<int>();
        var rightPart = new List<int>();
        for (var i = 1; i < ar.Length; i++)
        {
            if (ar[i] < pivot)
                leftPart.Add(ar[i]);
            if (ar[i] > pivot)
                rightPart.Add(ar[i]);
        }
        foreach (var leftElem in leftPart)
        {
            Console.Write(leftElem + " ");
        }
        Console.Write(pivot + " ");
        foreach (var rightElem in rightPart)
        {
            Console.Write(rightElem + " ");
        }
    }
    /* Tail starts here */
    static void Main(String[] args)
    {

        int _ar_size;
        _ar_size = Convert.ToInt32(Console.ReadLine());
        int[] _ar = new int[_ar_size];
        String elements = Console.ReadLine();
        String[] split_elements = elements.Split(' ');
        for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
        {
            _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
        }

        partition(_ar);
    }
}
