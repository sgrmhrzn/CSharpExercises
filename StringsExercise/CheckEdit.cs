using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class CheckEdit
    {
        /// <summary>
        /// compares two string if they are one edit or zero edit away
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public bool CheckIfEditCanBePerformed(string firstValue, string secondValue)
        {
            bool result = false;
            int diff = firstValue.Except(secondValue).Count();
            if (firstValue.Length != secondValue.Length)
            {
                if (secondValue.Length > firstValue.Length && (secondValue.Length - firstValue.Length) == 1 && diff == 1)
                {
                    result = true;
                }
                if (firstValue.Length > secondValue.Length && (firstValue.Length - secondValue.Length) == 1 && diff == 1)
                {
                    result = true;
                }
            }
            if (firstValue.Length == secondValue.Length)
            {
                if (diff > 1)
                    result = false;
                if (diff == 1)
                    result = true;
            }
            return result;
        }

    }
}
