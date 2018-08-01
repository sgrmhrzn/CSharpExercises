using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekThree
{
    public class Berth
    {
        public string BerthType(int seatNumber)
        {
            string result = "";
            int totalNumberOfSeats = 72;
            int totalCompartments = 9;
            int totalSeatsInSingleCompartment = 8;
            int seatCount = 1;

            if (seatNumber <= totalNumberOfSeats && seatNumber > 0)
            {
                for (int j = 0; j < totalCompartments; j++)
                {
                    int[] compartment = new int[totalSeatsInSingleCompartment];
                    int seatIndex = 0;
                    do
                    {
                        compartment.SetValue(seatCount, seatIndex);
                        seatCount++;
                        seatIndex++;
                    } while (compartment.Any(x => x.Equals(0)));

                    int seatIndexInCompartment = Array.IndexOf(compartment, seatNumber);
                    if (seatIndexInCompartment > 0)
                    {
                        if (seatIndexInCompartment == 0 || seatIndexInCompartment == 3)
                            result = "LB";
                        else if (seatIndexInCompartment == 1 || seatIndexInCompartment == 4)
                            result = "MB";
                        else if (seatIndexInCompartment == 2 || seatIndexInCompartment == 5)
                            result = "UB";
                        else if (seatIndexInCompartment == 6)
                            result = "SLB";
                        else if (seatIndexInCompartment == 7)
                            result = "SUB";
                        break;
                    };
                }
            }
            else
            {
                result = "Seat number does not exists!";
            }
            return result;
        }
    }
}
