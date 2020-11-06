using System;

namespace SctructualPatternFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelAgency travelAgency = new TravelAgency();
            travelAgency.Menu();
        }
    }
}