using System;
using System.Collections.Generic;

namespace TestDome.FreeInterviewQuestionsC
{
    /*
    Write a function that, when passed a list and a target sum, returns, efficiently with respect to time used, two distinct zero-based indices of any two of the numbers, 
    whose sum is equal to the target sum. If there are no two numbers, the function should return null.

    For example, FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10) should return a Tuple<int, int> containing any of the following pairs of indices:

    0 and 3 (or 3 and 0) as 3 + 7 = 10
    1 and 5 (or 5 and 1) as 1 + 9 = 10
    2 and 4 (or 4 and 2) as 5 + 5 = 10
    */
    public class TwoSum
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            // 4/4 testdome tests passed
            HashSet<int> hashSet = new HashSet<int>();
            for(int i = 0; i < list.Count; i++)
            {
                var searched = sum - list[i];
                if(hashSet.Contains(searched))
                    return Tuple.Create<int, int>(list[searched], i);
                
                hashSet.Add(list[i]);
            }

            // 3/4 testdome tests passed
            // if (list == null || list.Count < 2) 
            //     return null;

            // Dictionary<int, int> indexDict = new Dictionary<int, int>();
            // for(int i = 0; i < list.Count; i++)
            // {
            //     int searched = sum - list[i]; // 10 - 3 = 7
            //     if(indexDict.ContainsKey(searched))
            //         return Tuple.Create<int, int>(indexDict[searched], i);

            //     indexDict.Add(list[i], i); // 3, 0
            // }

            // 3/4 testdome tests passed
            // for(int x = 0; x < list.Count; x++)
            // {
            //     for(int y = 0; y < list.Count; y++)
            //     {
            //         if(x == y)
            //             continue;

            //         if(list[x] + list[y] == sum)
            //             return Tuple.Create<int, int>(x, y);
            //     }
            // }

            // 2/4 testdome tests passed
            // sum - list[n]
            // for(int index = 0; index < list.Count; index++)
            // {
            //     int second = list.IndexOf(sum - list[index]);
            //     if(second == -1)
            //         continue;
                    
            //     return Tuple.Create<int, int>(index, second);
            // }
            return null;
        }

        public static void Main(string[] args)
        {
            int sum = 10;
            var list = new List<int>() { 3, 1, 5, 7, 5, 9 };
            Tuple<int, int> indices = FindTwoSum(list, sum);
            if(indices != null) 
            {
                Console.WriteLine(indices.Item1 + " " + indices.Item2);
            }
        }
    }
}