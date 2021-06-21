using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using AnagramConsole.Common.Interfaces;

namespace AnagramConsole.Common.Adapters
{
    public class GridReaderWrapper : IGridReaderWrapper
    {
        private readonly SqlMapper.GridReader _gridReader;

        public GridReaderWrapper(SqlMapper.GridReader gridReader)
        {
            _gridReader = gridReader;
        }

        public async Task<T> ReadFirstAsync<T>()
        {
            return await _gridReader.ReadFirstAsync<T>();
        }

        public async Task<T> ReadFirstOrDefaultAsync<T>()
        {
            var entities = (await _gridReader.ReadAsync<T>()).AsList();

            if (entities.Count == 0)
                return default(T);

            return entities[0];
        }

        public async Task<IEnumerable<T>> ReadAsync<T>()
        {
            return await _gridReader.ReadAsync<T>();
        }

        public void Dispose()
        {
            _gridReader.Dispose();
        }
    }
}
