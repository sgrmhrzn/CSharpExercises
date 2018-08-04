using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Permutation
    {
        /// <summary>
        /// compares two strings and check if second value is permutation of first value or not
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public bool CheckPermutation(string firstValue, string secondValue)
        {
            Dictionary<char, int> countCharDictionary = new Dictionary<char, int>(firstValue.Length);
            foreach (char c in firstValue)
            {
                if (countCharDictionary.Keys.Contains(c))
                {
                    countCharDictionary[c]++;
                }
                else
                {
                    countCharDictionary.Add(c, 1);
                }
            }
            foreach (char c in secondValue)
            {
                if (countCharDictionary.Keys.Contains(c))
                {
                    if (countCharDictionary[c] == 0)
                        return false;
                    countCharDictionary[c]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
