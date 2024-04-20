using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    // Interface for the name sorter
    public interface INameSorter
    {
        public List<Person> SortNamesByLastName(List<Person> people);
    }
}
