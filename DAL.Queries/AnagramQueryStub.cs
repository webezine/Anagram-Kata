using AnagramConsole.Common.Interfaces;
using DAL.Queries.Interfaces;
using Models;
using System.Collections.Generic;

namespace DAL.Queries
{
    public class AnagramQueryStub : IAnagramQuery
    {
        private readonly ILoggerAdapter<AnagramQuery> _logger;

        public AnagramQueryStub(ILoggerAdapter<AnagramQuery> logger)
        {
            _logger = logger;
        }

        public List<AnagramResult> GetAnagramsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
