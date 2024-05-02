using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public interface IIOManager
    {
        public List<Person> ReadFile(string filePath);
        public void WriteFile(string filePath, List<Person> people);
    }
}
