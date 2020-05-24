using System;

namespace Library.Reservation
{
    public class Reservation
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Book.Book Book { get; set; }

        public void Feature01()
        {
            throw new NotImplementedException();
        }
    }
}