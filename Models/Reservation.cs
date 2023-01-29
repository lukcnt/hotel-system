using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotel_system.Models
{
    public class Reservation
    {
        public Reservation()
        {

        }

        public Reservation(int bookedDays)
        {
            BookedDays = bookedDays;
        }

        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int BookedDays { get; set; }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public void RegisterGuests(List<Person> guests)
        {
            bool verifyCapacity = Suite.Capacity >= guests.Count;

            if (verifyCapacity)
            {
                Guests = guests;
            }
            else
            {
                throw new Exception("The capacity of the suite is shorter than the number fo guests.");
            }
        }

        public int GetGuestsQuantity()
        {
            int guestsQuantity = Guests.Count;

            return guestsQuantity;
        }
    }
}