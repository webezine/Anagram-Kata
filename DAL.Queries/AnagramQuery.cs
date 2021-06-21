using AnagramConsole.Common.Interfaces;
using AnagramConsole.DAL.Queries;
using DAL.Queries.Interfaces;
using Models;
using System.Collections.Generic;

namespace DAL.Queries
{
    public class AnagramQuery : BaseQuery, IAnagramQuery
    {
        private readonly ILoggerAdapter<AnagramQuery> _logger;

        public AnagramQuery(IDapperWrapperFactory connectionFactory,
            ILoggerAdapter<AnagramQuery> logger) : base(connectionFactory)
        {
            _logger = logger;
        }

        public List<AnagramResult> GetAnagramsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
