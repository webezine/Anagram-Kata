using System;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using AnagramConsole.Common.Adapters;
using AnagramConsole.Common.Interfaces;

namespace AnagramConsole.Common.Factories
{
    public class DapperWrapperFactory : IDapperWrapperFactory
    {
        readonly string _connectionString;

        public DapperWrapperFactory(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString), "Invalid Connection string. Value cannot be null or blank");
            }

            _connectionString = connectionString;
        }

        public IDapperWrapper GetOpenConnection()
        {
            var dbConnection = new SqlConnection(_connectionString);
            dbConnection.Open();
            return new DapperWrapper(dbConnection);
        }

        public async Task<IDapperWrapper> GetOpenAsyncConnection(CancellationToken cancellationToken)
        {
            var dbConnection = new SqlConnection(_connectionString);
            await dbConnection.OpenAsync(cancellationToken);
            return new DapperWrapper(dbConnection);
        }
    }
}
