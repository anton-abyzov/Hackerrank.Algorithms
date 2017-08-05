using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeIndex
{
    public class Program1
    {
        public static bool isPalindrome(string str)
        {
            bool isPalindrome = str.Equals(String.Join("", str.Reverse()));
            return isPalindrome;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var strings = new List<String>();

            for (int i = 0; i < n; i++)
            {
                strings.Add(Console.ReadLine().Trim().ToLower());
            }

            var palindromeIndices = new List<int>();

            foreach (string item in strings)
            {
                int palindromeCharIndex = -1;

                if (!isPalindrome(item))
                {
                    int i = 0, j = item.Length - 1;
                    char currentChar, lastChar;

                    while (j >= i)
                    {
                        currentChar = item[i];
                        lastChar = item[j];

                        if (currentChar != lastChar)
                        {
                            string skipRight = item.Substring(i, item.Length - (i * 2) - 1);
                            string skiptLeft = item.Substring(i + 1, item.Length - 1 - (i * 2));

                            if (isPalindrome(skipRight))
                            {
                                palindromeCharIndex = j;
                                break;
                            }
                            if (isPalindrome(skiptLeft))
                            {
                                palindromeCharIndex = i;
                                break;
                            }
                        }
                        i++;
                        j--;
                    }
                }
                palindromeIndices.Add(palindromeCharIndex > -2 ? palindromeCharIndex : -9999);
            }
            palindromeIndices.ForEach(d => Console.WriteLine(d));
        }

       
    }
}