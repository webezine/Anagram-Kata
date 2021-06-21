using DAL.Queries.Interfaces;
using System;

namespace AnagramConsole.Services
{
    public class AnagramChecker : IAnagramChecker
    {
        private readonly IAnagramQuery _anagramQuery;

        public AnagramChecker(IAnagramQuery anagramQuery)
        {
            _anagramQuery = anagramQuery;
        }

        public void FetchAndOutputAnagramResults()
        {
            Console.WriteLine("Welcome to the DataSym Anagram Technical Analyser - DATA for short...");
            Console.WriteLine("Click any button to start...");
            Console.ReadLine();
            Console.WriteLine("Fetching results...");
            var result = _anagramQuery.GetAnagramsAsync();

        }
    }
}
