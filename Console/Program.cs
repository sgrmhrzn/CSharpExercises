using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekTwo;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] A = new int[5] { 3, 8, 9, 7, 6 };
            int[] expected = new int[5] { 9, 7, 6, 3, 8 };

            var result = solution.FirstChallenge(A, 3);

            foreach (var r in result)
            {
                Console.WriteLine("value:" + r);
            }
            if(result == expected)
            {
                Console.WriteLine(true);
            }

            //int[] A = new int[7];
            //A.SetValue(9, 0);
            //A.SetValue(3, 1);
            //A.SetValue(9, 2);
            //A.SetValue(3, 3);
            //A.SetValue(9, 4);
            //A.SetValue(7, 5);
            //A.SetValue(9, 6);


            //var result = solution.thirdChallenge(10, 85, 30);

            Console.ReadLine();
        }
    }
}
