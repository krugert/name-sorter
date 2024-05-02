using name_sorter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public class Person : IPerson
    {
        public string FirstName { get; set; } // read-only auto-implemented property
        public string LastName { get; set; } // read-only auto-implemented property

        public Person()
        {
            this.FirstName = "";
            this.LastName = "";
        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // return a string containing the person information
        public override string ToString() => $"{FirstName} {LastName}";
    }
}
