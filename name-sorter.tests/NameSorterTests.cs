using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using name_sorter;
using System.Reflection.PortableExecutable;

namespace name_sorter.tests
{
    public class NameSorterTests
    {
        LastNameSorter testCase = new LastNameSorter();
        Person lastNameTestCase = new Person();

        [Fact]
        public void CheckIfFileExists()
        {
            // Arrange
            string inputFilePath = @"../../../../name-sorter/bin/Debug/net8.0/unsorted-names-list.txt";

            var stream = new IOManager();
            var nameSorter = new LastNameSorter();

            // Act
            List<Person> people = stream.ReadFile(inputFilePath);

            // Assert
            Assert.True(File.Exists(inputFilePath));
        }

        [Fact]
        public void CheckIfFileCanBeAccessed()
        {

        }

        [Fact]
        public void CheckIfOnlyLastNameWasReturned()
        {
            // Arrange
            List<string> expected = new List<string> {
                new string("Parsons"),
                new string("Archer"),
                new string("Alvarez")
            };

            List<string> names = new List<string> {
                new string("Janet Parsons"),
                new string("Adonis Julius Archer"),
                new string("Marin Alvarez")
            };

            // Act
            List<string> actual = new List<string>();

            foreach (string name in names)
            {
                StringOperationService stringOperationService = new StringOperationService();
                actual.Add(stringOperationService.GetLastName(name));

            }

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckIfNamesWereSortedByLastName()
        {
            // Arrange
            List<Person> expected = new List<Person>{
                new Person("Jane", "Doe"),
                new Person("John", "Doe")
            };

            List<Person> unsortedPersons = new List<Person>{
                new Person("John", "Doe"),
                new Person("Jane", "Doe")
            };

            // Act
            List<Person> actual = testCase.SortNamesByLastName(unsortedPersons);

            // Assert
            Enumerable.SequenceEqual(expected, actual);
        }
    }
}