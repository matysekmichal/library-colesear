using System;
using Library.vendor.Observer;

namespace Library.Reservation
{
    public class ReservationObserver : Observer
    {
        private readonly Reservation _reservation;

        public ReservationObserver(Reservation reservation)
        {
            _reservation = reservation;
        }

        public override void Publish()
        {
            Console.WriteLine($"{_reservation.Name} {_reservation.LastName} zarezerwował {_reservation.Book.Name}.");
        }
    }
}