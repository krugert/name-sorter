using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public interface IPerson
    {
        public string FirstName { get; set; } // read-only auto-implemented property
        public string LastName { get; set; } // read-only auto-implemented property
    }
}
