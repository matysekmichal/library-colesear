using System.Collections.Generic;
using Library.Reservation;

namespace Library
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var reservation = new Reservation.Reservation()
            {
                Name = "John",
                LastName = "Galt",
                Book = new Book.Book()
                {
                    Name = "BookName",
                    ISBN = "978-3-16-148410-0"
                }
            };

            var reservationObserver = new ReservationObserver(reservation);

            foreach (var librarian in GetLibrarians())
            {
                reservationObserver.RegisterObserver(new ReservationSubscriber(librarian));
            }

            reservationObserver.Publish();
            reservationObserver.NotifyObservers();
        }

        private static IEnumerable<Librarian.Librarian> GetLibrarians()
        {
            var librarians = new List<Librarian.Librarian>
            {
                new Librarian.Librarian() {Name = "Ayn", LastName = "Rand"},
                new Librarian.Librarian() {Name = "Ayn2", LastName = "Rand2"},
                new Librarian.Librarian() {Name = "Ayn3", LastName = "Rand3"}
            };

            return librarians;
        }
    }
}