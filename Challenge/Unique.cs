using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Unique
    {
        /// <summary>
        /// Checks if the char of string are unique or not
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CheckIfUnique(string value)
        {
            string valueToLower = value.ToLower();
            bool isUnique = false;
            for (var i = 0; i < valueToLower.Length; i++)
            {
                var charToCompare = valueToLower[i];
                for (var j = i + 1; j < valueToLower.Length - 1; j++)
                {
                    if (charToCompare != valueToLower[j])
                    {
                        isUnique = true;
                    }
                    else
                    {
                        isUnique = false;
                        return isUnique;
                    }
                }
            }
            return isUnique;
        }
    }
}
