using System;
using System.Collections.Generic;
using System.Text;

namespace SctructualPatternFacade
{
    public class TransportBooking
    {
       public void AssignADriver()
        {
            Console.WriteLine("A driver was assigned for transport you around the city you will be in.");
        }

        public void CancelDriver()
        {
            Console.WriteLine("The driver assigned for your trip has been canceled.");
        }
    }
}
