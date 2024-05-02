using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    // Implementation of the name sorter
    public class LastNameSorter : INameSorter
    {
        public List<IPerson> SortNamesByLastName(List<IPerson> people)
        {
            var result = from p in people
                         orderby p.LastName, p.FirstName
                         select p;

            return result.ToList();
        }
    }
}
