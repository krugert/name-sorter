using name_sorter;

namespace name_sorter.tests
{
    public class LastNameSorterTests
    {
        [Fact]
        public void CheckIfFileExists()
        {
            // Arrange
            string inputFilePath = @"./unsorted-names-list.txt";
            
            var stream = new IO();
            var nameSorter = new LastNameSorter();

            // Act
            List<Person> people = stream.ReadFile(inputFilePath);

            // Assert
            Assert.True(File.Exists(inputFilePath));
        }
    }
}