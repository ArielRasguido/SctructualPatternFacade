using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SctructualPatternFacade
{
    public class ReservationSystemFacade
    {
        private FlightBooking _flightReservationSystem;
        private HotelBooking _hotelReservationSystem;
        private TransportBooking _TrasportReservationSystem;

        public ReservationSystemFacade()
        {
            _flightReservationSystem = new FlightBooking();
            _hotelReservationSystem = new HotelBooking();
            _TrasportReservationSystem = new TransportBooking();
        }

        public void MakeAReservation()
        {
            Console.WriteLine("Thanks for choosing our services! Your requirements are being processed by our system. \nYour reservation is going to be completed soon, please hold on a moment... \n");
            Console.WriteLine("Loading...");
            Thread.Sleep(1000);
            _flightReservationSystem.ChooseAFlight();
            Thread.Sleep(1500);
            _hotelReservationSystem.BookARoom();
            Thread.Sleep(1500);
            _TrasportReservationSystem.AssignADriver();
            Thread.Sleep(500);
            Console.WriteLine("\nThe Reservation has been completed successfully!!");
            Console.WriteLine("Your Vacation Package is ready...Enjoy your trip!");
        }

        public void CancelAReservation()
        {
            Console.Write("Are you sure you want to cancel your reservation? (yes/no):");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "yes":
                    Console.WriteLine("\nLoading...");
                    Thread.Sleep(1000);
                    _flightReservationSystem.CancelFlight();
                    Thread.Sleep(1000);
                    _hotelReservationSystem.CancelRoom();
                    Thread.Sleep(1000);
                    _TrasportReservationSystem.CancelDriver();
                    Thread.Sleep(500);
                    Console.WriteLine("\nThe Reservation has been canceled.");
                    break;
                case "no":
                    Console.WriteLine("Operation canceled.");
                    break;
                default:
                    Console.WriteLine("Incorrect option.");
                    break;
            }
        }
    }
}
