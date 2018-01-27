using System;
using System.Collections.Generic;

namespace StringTwins_CrossoverTournament
{
    class Program
    {
        /*
         * Complete the function below.
         * DO NOT MODIFY CODE OUTSIDE THIS FUNCTION!
         */
        static string[] twins(string[] a, string[] b)
        {

            var results = new List<string>();
            for (var i = 0; i < a.Length; i++)
            {
                var first = a[i];
                var second = b[i];
                if (first.Length != second.Length)
                {
                    results.Add("No");
                    break;
                }
                var even1 = new Dictionary<char, int>();
                var odd1 = new Dictionary<char, int>();
                var even2 = new Dictionary<char, int>();
                var odd2 = new Dictionary<char, int>();
                for (var j = 0; j < first.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        AddToDictIfNotExists(even1, first[j]);
                        AddToDictIfNotExists(even2, second[j]);
                        even1[first[j]] += 1;
                        even2[second[j]] += 1;
                    }
                    else
                    {
                        AddToDictIfNotExists(odd1, first[j]);
                        AddToDictIfNotExists(odd2, second[j]);
                        odd1[first[j]] += 1;
                        odd2[second[j]] += 1;
                    }
                }
                var result = setEquals(even1, even2) && setEquals(odd1, odd2);
                if (result)
                {
                    results.Add("Yes");
                }
                else
                {
                    results.Add("No");
                }
            }
            return results.ToArray();
        }

        static void AddToDictIfNotExists(Dictionary<char, int> dict, char elem)
        {
            if (!dict.ContainsKey(elem))
                dict.Add(elem, 0);
        }

        static bool setEquals(Dictionary<char, int> set1, Dictionary<char, int> set2)
        {
            bool equal = false;
            if (set1.Count == set2.Count) // Require equal count.
            {
                equal = true;
                foreach (var pair in set1)
                {
                    int value;
                    if (set2.TryGetValue(pair.Key, out value))
                    {
                        // Require value be equal.
                        if (value != pair.Value)
                        {
                            equal = false;
                            break;
                        }
                    }
                    else
                    {
                        // Require key be present.
                        equal = false;
                        break;
                    }
                }
            }
            return equal;
        }

        // DO NOT MODIFY CODE OUTSIDE THE ABOVE FUNCTION!

        static void Main(String[] args)
        {
            string[] res;

            int _a_size = 0;
            _a_size = Convert.ToInt32(Console.ReadLine());
            string[] _a = new string[_a_size];
            string _a_item;
            for (int _a_i = 0; _a_i < _a_size; _a_i++)
            {
                _a_item = Console.ReadLine();
                _a[_a_i] = _a_item;
            }


            int _b_size = 0;
            _b_size = Convert.ToInt32(Console.ReadLine());
            string[] _b = new string[_b_size];
            string _b_item;
            for (int _b_i = 0; _b_i < _b_size; _b_i++)
            {
                _b_item = Console.ReadLine();
                _b[_b_i] = _b_item;
            }

            res = twins(_a, _b);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
        }
    }
}
