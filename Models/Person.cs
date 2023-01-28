using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotel_system.Models
{
    public class Person
    {
        public Person()
        {

        }

        public Person(string firstName)
        {
            FirstName = firstName;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompleteName => $"{FirstName} {LastName}".ToUpper();
    }
}