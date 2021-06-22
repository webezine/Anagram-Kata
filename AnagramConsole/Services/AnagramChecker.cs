using DAL.Queries.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AnagramConsole.Services
{
    public class AnagramChecker : IAnagramChecker
    {
        private readonly IAnagramQuery _anagramQuery;

        public AnagramChecker(IAnagramQuery anagramQuery)
        {
            _anagramQuery = anagramQuery;
        }

        public async Task FetchAndOutputAnagramResults()
        {
            Console.WriteLine("Welcome to the DataSym Anagram Technical Analyser - D.A.T.A for short...");
            Console.WriteLine("Press enter to start...");
            Console.ReadLine();
            Console.WriteLine("Fetching results...");
            var result = await _anagramQuery.GetAnagramsAsync();
            Console.WriteLine($"{result.Count} result(s) found.");

            if (result.Any())
            {
                Console.WriteLine("Outputting the results...");
                Console.WriteLine();

                foreach (var item in result)
                {
                    if (item.Result)
                    {
                        // Is an anagram
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{item.WordOne}  |  {item.WordTwo} << Is an anagram!");

                    } else
                    {
                        // Is not an angram
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{item.WordOne}  |  {item.WordTwo} << Not an anagram. ");
                    }

                }
                Console.ResetColor();
                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using D.A.T.A; press enter to close the application.");
            Console.ReadLine();
        }
    }
}
