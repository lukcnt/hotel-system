using System.Text;
using hotel_system.Models;

Console.OutputEncoding = Encoding.UTF8;

// Create the models of the guests and register on the list of guests.
List<Person> guests = new List<Person>();

Person p1 = new Person(firstName: "Guest 1");
Person p2 = new Person(firstName: "Guest 2");
// Person p3 = new Person(firstName: "Guest 3");

guests.Add(p1);
guests.Add(p2);
// guests.Add(p3);

// Create a suite.
Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyPrice: 30);

// Create a new reservation, passing the suite and guests.
Reservation reservation = new Reservation(bookedDays: 10);
reservation.RegisterSuite(suite);
reservation.RegisterGuests(guests);

// Show the quantity of guests and the daily fee.
Console.WriteLine($"Guests: {reservation.GetGuestsQuantity()}");
Console.WriteLine($"Daily fee: ${reservation.CalculateDailyFee()}");