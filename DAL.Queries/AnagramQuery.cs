using AnagramConsole.Common.Interfaces;
using AnagramConsole.DAL.Queries;
using DAL.Queries.Interfaces;
using Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<AnagramResult> GetAnagramByIdAsync(int id)
        {
            _logger.Information($"AnagramQuery > GetAnagramByIdAsync >> Getting anagram that match the id {id}...");

            AnagramResult result;
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                result = await connection.QueryFirstAsync<AnagramResult>(SqlQueryGeneral.GetAnagramById, new { id },
                    commandType: CommandType.StoredProcedure);
            }
            return result;
        }

        public async Task<List<AnagramResult>> GetAnagramsAsync()
        {
            _logger.Information($"AnagramQuery > GetAnagramsAsync >> Getting list of anagram results...");

            List<AnagramResult> result;
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                result = (await connection.QueryAsync<AnagramResult>(SqlQueryGeneral.GetAnagram,
                    commandType: CommandType.StoredProcedure)).ToList();
            }
            return result;
        }

        public async Task<List<AnagramResult>> GetAnagramsByWordAsync(string word)
        {
            _logger.Information($"AnagramQuery > GetAnagramsByWordAsync >> Getting list of anagram that match the word {word}...");

            List<AnagramResult> result;
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                result = (await connection.QueryAsync<AnagramResult>(SqlQueryGeneral.GetAnagramByWord, new {word},
                    commandType: CommandType.StoredProcedure)).ToList();
            }
            return result;
        }
    }
}
