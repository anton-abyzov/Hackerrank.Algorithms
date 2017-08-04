using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    private static int _pivotIndex = 0;
    //static void quickSort(int[] ar, int left, int right)
    //{
    //    if (left >= right)
    //        return;
    //    var pivot = ar[left];
    //    //var pivot = ar[(left + right)/2];
    //    var partitionIndex = partition(ar, left, right, pivot);

    //    quickSort(ar,left, partitionIndex - 1);
    //    quickSort(ar, partitionIndex, right);
    //    for (int i = left; i <= right; i++)
    //    {
    //        Console.Write(ar[i] + " ");
    //    }
    //    Console.WriteLine();
    //}

    static void quickSort(int[] ar, int left, int right)
    {
        if (left >= right)
            return;
        //if (left + 1 == right)
        //    return;
        var pivot = ar[left];
        var partitionIndex = partitionNew(ar, left, right, pivot);
        quickSort(ar, left, partitionIndex - 1);
        quickSort(ar, partitionIndex + 1, right);
        for (int i = left; i <= right; i++)
        {
            Console.Write(ar[i] + " ");
        }
        Console.WriteLine();
    }

    private static void Swap(int[] ar, int left, int right)
    {
        var temp = ar[left];
        ar[left] = ar[right];
        ar[right] = temp;
    }

    static int partitionNew(int[] ar, int left, int right, int pivot)
    {
        if (left > right)
            return 0;
        var leftPart = new List<int>();
        var rightPart = new List<int>();
        for (var i = left; i <= right; i++)
        {
            if (ar[i] < pivot)
                leftPart.Add(ar[i]);
            if (ar[i] > pivot)
                rightPart.Add(ar[i]);
        }

        int currentIndex = 0;
        for (currentIndex = 0; currentIndex < leftPart.Count; currentIndex++)
        {
            ar[left + currentIndex] = leftPart[currentIndex];
        }
        ar[left + currentIndex] = pivot;
        var pivotIndex = currentIndex + left;
        
        var rigthPartIndex = 0;
        for (int rightPartIndex = 0; rightPartIndex < rightPart.Count; rightPartIndex++)
        {
            ar[rightPartIndex + pivotIndex + 1] = rightPart[rightPartIndex];
        }
        return pivotIndex;
    }

    static int partition(int[] ar, int left, int right, int pivot)
    {
        while (left <= right)
        {
            while (ar[left] < pivot)
                left++;
            while (ar[right] > pivot)
                right--;

            if (left <= right)
            {
                Swap(ar, left++, right--);
            }
        }
        return left;
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

        quickSort(_ar, 0, _ar.Length - 1);
    }
}
