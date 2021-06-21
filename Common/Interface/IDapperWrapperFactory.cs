using System.Threading;
using System.Threading.Tasks;

namespace AnagramConsole.Common.Interfaces
{
    public interface IDapperWrapperFactory
    {
        IDapperWrapper GetOpenConnection();

        Task<IDapperWrapper> GetOpenAsyncConnection(CancellationToken cancellationToken);

    }
}
