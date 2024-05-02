using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public class StringOperationService
    {
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
    }
}
