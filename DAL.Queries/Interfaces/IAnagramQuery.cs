using Models;
using System.Collections.Generic;

namespace DAL.Queries.Interfaces
{
    public interface IAnagramQuery
    {
        List<AnagramResult> GetAnagramsAsync();
    }
}
