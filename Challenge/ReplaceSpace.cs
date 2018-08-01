using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class ReplaceSpace
    {
        /// <summary>
        /// replaces spaces with '%20' inside the string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string Replace(string value)
        {
            var result = "";
            for (var i = 0; i < value.Length; i++)
            {
                if (value[i] == ' ')
                {
                    result += "%20";
                }
                else
                {
                    result += value[i];
                }

            }
            return result;
        }
    }
}
