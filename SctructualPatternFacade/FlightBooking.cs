using System;
using System.Collections.Generic;
using System.Text;

namespace SctructualPatternFacade
{
    public class FlightBooking
    {
        public void ChooseAFlight()
        {
            Console.WriteLine("A flight has been scheduled according your specifications.");
        }

        public void CancelFlight()
        {
            Console.WriteLine("The flight has been canceled.");
        }
    }
}
