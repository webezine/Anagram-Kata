using AnagramConsole.Common.Interfaces;
using DAL.Queries.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Queries
{
    public class AnagramQueryStub : IAnagramQuery
    {
        private readonly ILoggerAdapter<AnagramQuery> _logger;

        public AnagramQueryStub(ILoggerAdapter<AnagramQuery> logger)
        {
            _logger = logger;
            _result = new List<AnagramResult>
            {
                new AnagramResult (1, "test", "try"),
                new AnagramResult (2, "best", "steb"),
                new AnagramResult (3, "fly", "fli"),
                new AnagramResult (4, "wet been", "between"),
                new AnagramResult (5, "bubble", "squeak"),
                new AnagramResult (6, "tg", ""),
                new AnagramResult (7, "tgi", "tig"),
                new AnagramResult (8, "Mary", "supercali"),
                new AnagramResult (9, "moana", "a moan"),
                new AnagramResult (10, "456", "123"),
                new AnagramResult (11, "321", "123")
            };
        }

        private List<AnagramResult> _result;

        public async Task<AnagramResult> GetAnagramByIdAsync(int id)
        {
            return _result.FirstOrDefault(r => r.Id == id);
        }

        public async Task<List<AnagramResult>> GetAnagramsAsync()
        {
            return _result;
        }

        public async Task<List<AnagramResult>> GetAnagramsByWordAsync(string word)
        {
            return _result.Where(s => string.Equals(s.WordOne, word, StringComparison.OrdinalIgnoreCase) || 
                string.Equals(s.WordTwo, word, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
