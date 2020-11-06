using System;
using System.Collections.Generic;
using System.Text;

namespace SctructualPatternFacade
{
    public class HotelBooking
    {
        public void BookARoom()
        {
            Console.WriteLine("A specific room has been book for you as well as all the other services you'll required.");
        }

        public void CancelRoom()
        {
            Console.WriteLine("The room booked has been canceled.");
        }
    }
}
