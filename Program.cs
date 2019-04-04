using System;
using Family.Core;
using Family.Core.Commands;
using Family.Core.Interfaces;
using Family.Repository;
using System.Linq;
using Family.Core.Factories;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"Enter Text File Path and Press Enter key For Example 'D:\Family\test.txt':");
            string filePath = Console.ReadLine();
            var fileLines = System.IO.File.ReadAllLines(filePath).ToList();

            ICommandProcessor personCommandProcessor = new PersonCommandProcessor(new PersonRepository(),new PersonCommandDictionary());
            var output = personCommandProcessor.ProcessCommands(fileLines);

            IOutput outputGenerator = new ConsoleOutput();
            outputGenerator.GenerateOutput(output);

            Console.ReadLine();


        }
    }
}
