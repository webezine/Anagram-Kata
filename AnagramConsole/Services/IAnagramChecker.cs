using System.Threading.Tasks;

namespace AnagramConsole.Services
{
    public interface IAnagramChecker
    {
        Task FetchAndOutputAnagramResults();
    }
}
