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
    }
}