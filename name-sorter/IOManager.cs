using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    // IO reader class adhering to SRP
    public class IOManager : IIOManager
    {
        public List<Person> ReadFile(string filePath)
        {
            List<Person> people = new List<Person>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Person person = new Person();
                        StringOperationService stringOperationService = new StringOperationService();
                        person.FirstName = stringOperationService.GetFirstName(line);
                        person.LastName = stringOperationService.GetLastName(line);
                        people.Add(person);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
            return people;
        }

        public void WriteFile(string filePath, List<Person> people)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Person person in people)
                    {
                        writer.WriteLine(person);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }
    }
}
