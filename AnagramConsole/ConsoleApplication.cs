using AnagramConsole.Services;

namespace AnagramConsole
{
    public class ConsoleApplication
    {
        private readonly IAnagramChecker _anagramChecker;

        public ConsoleApplication(IAnagramChecker anagramChecker)
        {
            _anagramChecker = anagramChecker;
        }

        public void Run()
        {
            _anagramChecker.FetchAndOutputAnagramResults();
        }
    }
}