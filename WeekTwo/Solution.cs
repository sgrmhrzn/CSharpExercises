using System;
using System.Collections.Generic;

namespace WeekTwo
{
    public class Solution
    {
        /// <summary>
        /// rotates array A K times; that is, each element of A will be shifted to the right K times and returns final value
        /// </summary>
        /// <param name="a">actual array passed</param>
        /// <param name="k">times to rotate</param>
        /// <returns>final array of rotated array</returns>
        public int[] FirstChallenge(int[] a, int k)
        {
            int[] c = new int[a.Length];
            int[] b = new int[a.Length];
            bool isFirstExecution = true;
            for (var i = 0; i < k; i++)
            {

                if (isFirstExecution)
                {
                    c = a;
                }
                else
                {
                    c = b;
                    b = new int[a.Length];
                }
                for (var j = 0; j < c.Length; j++)
                {
                    if (j == c.Length - 1)
                    {
                        var lastIndex = c.Length - 1;
                        j = 0;
                        b.SetValue(c[lastIndex], j);
                        break;
                    }
                    else
                    {
                        b.SetValue(c[j], j + 1);
                    }
                }
                isFirstExecution = false;
            }
            return b;
        }
        
        /// <summary>
        /// adds paired values to dictoniory with count of each digit, and returns digit that is not paired
        /// </summary>
        /// <param name="a">actual array that is passed</param>
        /// <returns>integer of unpaired digit</returns>
        public int SecondChallenge(int[] a)
        {
            int c = 0;
            Dictionary<int, int> countDigits = new Dictionary<int, int>();
            foreach (var v in a)
            {
                if (countDigits.ContainsKey(v))
                {
                    countDigits[v]++;
                }
                else
                {
                    countDigits.Add(v, 1);
                }
            }

            foreach (var dict in countDigits)
            {
                if (dict.Value == 1)
                {
                    c = dict.Key;
                }
            }
            return c;
        }

        /// <summary>
        /// Counst the minimal number of jumps that the small frog must perform to reach its target and returns the integer
        /// </summary>
        /// <param name="x">current located position</param>
        /// <param name="y">total distance to travel</param>
        /// <param name="z">distance the frog can jump once</param>
        /// <returns>total jump count</returns>
        public int ThirdChallenge(int x, int y, int z)
        {
            int jumpCount = 0;
            int totalDistanceCovered = x;
            do
            {
                jumpCount++;
                totalDistanceCovered += z;
            } while (totalDistanceCovered != y && totalDistanceCovered < y);
            return jumpCount;
        }
    }

}
