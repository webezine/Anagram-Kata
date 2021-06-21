using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnagramConsole.Common.Interfaces
{
    public interface IGridReaderWrapper : IDisposable
    {
        Task<T> ReadFirstAsync<T>();

        Task<T> ReadFirstOrDefaultAsync<T>();

        Task<IEnumerable<T>> ReadAsync<T>();
    }
}
