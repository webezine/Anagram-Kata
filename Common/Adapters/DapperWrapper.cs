using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using AnagramConsole.Common.Interfaces;

namespace AnagramConsole.Common.Adapters
{
    public class DapperWrapper : IDapperWrapper
    {
        private readonly IDbConnection _dbConnection;

        public DapperWrapper(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<dynamic>> QueryAsync(string sql, object param = null,
            IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            await _dbConnection.QueryAsync(sql, param, transaction, commandTimeout, commandType);

        public async Task<IEnumerable<dynamic>> QueryAsync(CommandDefinition command) =>
            await _dbConnection.QueryAsync(command);

        public async Task<dynamic> QueryFirstAsync(CommandDefinition command) => await _dbConnection.QueryFirstAsync(command);

        public async Task<dynamic> QueryFirstOrDefaultAsync(CommandDefinition command) => await _dbConnection.QueryFirstOrDefaultAsync(command);

        public async Task<dynamic> QuerySingleAsync(CommandDefinition command) => await _dbConnection.QuerySingleAsync(command);

        public async Task<dynamic> QuerySingleOrDefaultAsync(CommandDefinition command) => await _dbConnection.QuerySingleOrDefaultAsync(command);

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QueryAsync<T>(sql, param,
            transaction, commandTimeout, commandType);

        public async Task<T> QueryFirstAsync<T>(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QueryFirstAsync<T>(sql, param,
            transaction, commandTimeout, commandType);

        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QueryFirstOrDefaultAsync<T>(
            sql, param, transaction, commandTimeout, commandType);

        public async Task<T> QuerySingleAsync<T>(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QuerySingleAsync<T>(sql,
            param, transaction, commandTimeout, commandType);

        public async Task<T> QuerySingleOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QuerySingleOrDefaultAsync<T>(
            sql, param, transaction, commandTimeout, commandType);

        public async Task<dynamic> QueryFirstAsync(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QueryFirstAsync(sql, param,
            transaction, commandTimeout, commandType);

        public async Task<dynamic> QueryFirstOrDefaultAsync(string sql, object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QueryFirstOrDefaultAsync(sql,
            param, transaction, commandTimeout, commandType);

        public async Task<dynamic> QuerySingleAsync(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QuerySingleAsync(sql, param,
            transaction, commandTimeout, commandType);

        public async Task<dynamic> QuerySingleOrDefaultAsync(string sql, object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QuerySingleOrDefaultAsync(sql,
            param, transaction, commandTimeout, commandType);

        public async Task<IEnumerable<object>> QueryAsync(Type type, string sql, object param = null,
            IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            await _dbConnection.QueryAsync(type, sql, param, transaction, commandTimeout, commandType);

        public async Task<object> QueryFirstAsync(Type type, string sql, object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QueryFirstAsync(type, sql,
            param, transaction, commandTimeout, commandType);

        public async Task<object> QueryFirstOrDefaultAsync(Type type, string sql, object param = null,
            IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            await _dbConnection.QueryFirstOrDefaultAsync(type, sql, param, transaction, commandTimeout, commandType);

        public async Task<object> QuerySingleAsync(Type type, string sql, object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QuerySingleAsync(type, sql,
            param, transaction, commandTimeout, commandType);

        public async Task<object> QuerySingleOrDefaultAsync(Type type, string sql, object param = null,
            IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null) =>
            await _dbConnection.QuerySingleOrDefaultAsync(type, sql, param, transaction, commandTimeout, commandType);

        public async Task<IEnumerable<T>> QueryAsync<T>(CommandDefinition command) => await _dbConnection.QueryAsync<T>(command);

        public async Task<IEnumerable<object>> QueryAsync(Type type, CommandDefinition command) =>
            await _dbConnection.QueryAsync(type, command);

        public async Task<object> QueryFirstAsync(Type type, CommandDefinition command) =>
            await _dbConnection.QueryFirstAsync(type, command);

        public async Task<T> QueryFirstAsync<T>(CommandDefinition command) => await _dbConnection.QueryFirstAsync<T>(command);

        public async Task<object> QueryFirstOrDefaultAsync(Type type, CommandDefinition command) =>
            await _dbConnection.QueryFirstOrDefaultAsync(type, command);

        public async Task<T> QueryFirstOrDefaultAsync<T>(CommandDefinition command) =>
            await _dbConnection.QueryFirstOrDefaultAsync<T>(command);

        public async Task<object> QuerySingleAsync(Type type, CommandDefinition command) =>
            await _dbConnection.QuerySingleAsync(type, command);

        public async Task<T> QuerySingleAsync<T>(CommandDefinition command) => await _dbConnection.QuerySingleAsync<T>(command);

        public async Task<object> QuerySingleOrDefaultAsync(Type type, CommandDefinition command) =>
            await _dbConnection.QuerySingleOrDefaultAsync(type, command);

        public async Task<T> QuerySingleOrDefaultAsync<T>(CommandDefinition command) =>
            await _dbConnection.QuerySingleOrDefaultAsync<T>(command);

        public async Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.ExecuteAsync(sql, param,
            transaction, commandTimeout, commandType);

        public async Task<int> ExecuteAsync(CommandDefinition command) => await _dbConnection.ExecuteAsync(command);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(string sql,
            Func<TFirst, TSecond, TReturn> map,
            object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id",
            int? commandTimeout = null, CommandType? commandType = null) =>
            await _dbConnection.QueryAsync<TFirst, TSecond, TReturn>(sql, map,
                param, transaction, buffered, splitOn,
                commandTimeout, commandType);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(CommandDefinition command,
            Func<TFirst, TSecond, TReturn> map, string splitOn = "Id") =>
            await _dbConnection.QueryAsync<TFirst, TSecond, TReturn>(command,
                map, splitOn);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(string sql,
            Func<TFirst, TSecond, TThird, TReturn> map, object param = null, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            await _dbConnection.QueryAsync<TFirst, TSecond, TThird, TReturn>(sql,
                map, param, transaction,
                buffered, splitOn, commandTimeout, commandType);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(CommandDefinition command,
            Func<TFirst, TSecond, TThird, TReturn> map, string splitOn = "Id") =>
            await _dbConnection.QueryAsync<TFirst, TSecond, TThird, TReturn>(command, map, splitOn);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(string sql,
            Func<TFirst, TSecond, TThird, TFourth, TReturn> map, object param = null, IDbTransaction transaction = null,
            bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null) =>
            await _dbConnection.QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(sql,
                map, param, transaction,
                buffered, splitOn, commandTimeout, commandType);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(
            CommandDefinition command,
            Func<TFirst, TSecond, TThird, TFourth, TReturn> map, string splitOn = "Id") =>
            await _dbConnection.QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(command, map, splitOn);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sql,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, object param = null,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null,
            CommandType? commandType = null) =>
            await _dbConnection.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(sql,
                map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(
            CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map,
            string splitOn = "Id") => await _dbConnection.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(
            command, map, splitOn);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(
            string sql,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, object param = null,
            IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null,
            CommandType? commandType = null) =>
            await _dbConnection.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(sql,
                map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(
            CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map,
            string splitOn = "Id") =>
            await _dbConnection.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(
                command, map, splitOn);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh,
            TReturn>(
            string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map,
            object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id",
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection
            .QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(
                sql, map, param, transaction, buffered, splitOn,
                commandTimeout, commandType);

        public async Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh,
            TReturn>(
            CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map,
            string splitOn = "Id") =>
            await _dbConnection.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(
                command, map, splitOn);

        public async Task<IEnumerable<TReturn>> QueryAsync<TReturn>(string sql, Type[] types, Func<object[], TReturn> map,
            object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id",
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.QueryAsync<TReturn>(sql,
            types, map, param, transaction, buffered, splitOn, commandTimeout, commandType);

        public async Task<IGridReaderWrapper> QueryMultipleAsync(string sql, object param = null,
            IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            var gridReaderWrapper = new GridReaderWrapper(

                await _dbConnection.QueryMultipleAsync(sql, param,
                    transaction, commandTimeout, commandType));

            return gridReaderWrapper;
        }

        public async Task<SqlMapper.GridReader> QueryMultipleAsync(CommandDefinition command) =>
            await _dbConnection.QueryMultipleAsync(command);

        public async Task<IDataReader> ExecuteReaderAsync(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.ExecuteReaderAsync(sql, param,
            transaction, commandTimeout, commandType);

        public async Task<IDataReader> ExecuteReaderAsync(CommandDefinition command) =>
            await _dbConnection.ExecuteReaderAsync(command);

        public async Task<IDataReader> ExecuteReaderAsync(CommandDefinition command, CommandBehavior commandBehavior) =>
            await _dbConnection.ExecuteReaderAsync(command, commandBehavior);

        public async Task<object> ExecuteScalarAsync(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.ExecuteScalarAsync(sql, param,
            transaction, commandTimeout, commandType);

        public async Task<T> ExecuteScalarAsync<T>(string sql, object param = null, IDbTransaction transaction = null,
            int? commandTimeout = null, CommandType? commandType = null) => await _dbConnection.ExecuteScalarAsync<T>(sql,
            param, transaction, commandTimeout, commandType);

        public async Task<object> ExecuteScalarAsync(CommandDefinition command) => await _dbConnection.ExecuteScalarAsync(command);

        public async Task<T> ExecuteScalarAsync<T>(CommandDefinition command) => await _dbConnection.ExecuteScalarAsync<T>(command);

        public IDbTransaction BeginTransaction()
        {
            return _dbConnection.BeginTransaction();
        }


        public void Dispose()
        {
            _dbConnection.Dispose();
        }
    }
}
