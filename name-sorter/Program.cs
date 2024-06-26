﻿using System;

namespace name_sorter
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "";
            string outputFilePath = "sorted-names-list.txt";

            // File path to read
            if (args.Length == 0)
            {
                inputFilePath = "unsorted-names-list.txt";
            }
            else
            {
                inputFilePath = args[0];
            }

            // Using dependency injection to inject File and LastNameSorter
            var stream = new IOManager();
            var nameSorter = new LastNameSorter();

            // Read names from the file
            List<IPerson> people = stream.ReadFile(inputFilePath);

            // Sort names by last name
            List<IPerson> sortedPeople = nameSorter.SortNamesByLastName(people);

            // Output sorted names
            Console.WriteLine("Sorted Names:");
            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person);
            }

            // Write names to the file
            stream.WriteFile(outputFilePath, sortedPeople);
        }
    }
}
