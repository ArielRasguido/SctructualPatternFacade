using System;
using System.Collections.Generic;
using System.Text;

namespace SctructualPatternFacade
{
    public class TravelAgency
    {
        private ReservationSystemFacade ReservationSystem;

        public TravelAgency()
        {
            ReservationSystem = new ReservationSystemFacade();
        }

        public void Menu()
        {
            int op = -1;
            do
            {
                Console.WriteLine("---Travel Agency---");
                Console.WriteLine("1. Make a travel package reservation");
                Console.WriteLine("2. Cancel a travel package");
                Console.WriteLine("0. Exit");
                op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        ReservationSystem.MakeAReservation();
                        break;
                    case 2:
                        ReservationSystem.CancelAReservation();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press a key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (op != 0);
        }
    }
}
