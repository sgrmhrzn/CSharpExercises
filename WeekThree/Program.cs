using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekThree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the seat number:");
            var seatNumber = Console.ReadLine();
            Berth berth = new Berth();
            var result = berth.BerthType(Convert.ToInt32(seatNumber));

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
