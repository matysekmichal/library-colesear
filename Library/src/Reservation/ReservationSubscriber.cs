using System;
using Library.vendor.Observer;

namespace Library.Reservation
{
    public class ReservationSubscriber : IObserver
    {
        private readonly Librarian.Librarian _librarian;

        public ReservationSubscriber(Librarian.Librarian librarian)
        {
            _librarian = librarian;
        }

        public void Update()
        {
            Console.WriteLine($"{_librarian.Name} {_librarian.LastName} w systemie pojawiała się nowa rezerwacja.");
        }
    }
}