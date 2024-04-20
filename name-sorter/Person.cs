using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public class Person
    {
        public string FirstName { get; set; } // read-only auto-implemented property
        public string LastName { get; set; } // read-only auto-implemented property

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFirstName(string fullName)
        {
            int length = fullName.LastIndexOf(' ');
            return fullName.Substring(0, length);
        }

        public string GetLastName(string fullName)
        {
            int startIndex = fullName.LastIndexOf(' ') + 1;
            int length = fullName.Length - startIndex;

            return fullName.Substring(startIndex, length);
        }

        // return a string containing the person information
        public override string ToString() => $"{FirstName} {LastName}";
    }
}
