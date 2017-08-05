//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{

//    static int palindromeIndex(string s)
//    {
//        if (isPalindrome(s))
//            return -1;
//        for (int i = 0; i < s.Length; i++)
//        {
//            if (isPalindrome(s.Remove(i, 1)))
//                return i;
//        }
//        return -1;
//    }

//    static bool isPalindrome(string s)
//    {
//        //for (int i = 0; i < s.Length/2; i++)
//        //{
//        //    if (s[i] != s[s.Length - 1 - i])
//        //        return false;
//        //}
//        //return true;
//        //var secondHalfIndex = s.Length / 2;
//        //var secondHalfIndex = (s.Length % 2 == 1) ? (s.Length / 2 + 1) : (s.Length / 2);
//        //var firstHalf = s.Substring(0, s.Length / 2);
//        //var secondHalf = s.Substring(secondHalfIndex);
//        //return firstHalf == secondHalf;
//        var reverse = new String(s.Reverse().ToArray());
//        return s == reverse;
//    }

//    static void Main(String[] args)
//    {
//        int q = Convert.ToInt32(Console.ReadLine());
//        for (int a0 = 0; a0 < q; a0++)
//        {
//            string s = Console.ReadLine();
//            int result = palindromeIndex(s);
//            Console.WriteLine(result);
//        }
//    }
//}
