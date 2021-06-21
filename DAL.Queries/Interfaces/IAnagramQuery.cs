using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Queries.Interfaces
{
    public interface IAnagramQuery
    {
        Task<List<AnagramResult>> GetAnagramsAsync();

        Task<AnagramResult> GetAnagramByIdAsync(int id);

        Task<List<AnagramResult>> GetAnagramsByWordAsync(string word);
    }
}
