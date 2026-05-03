using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using static Dapper.SqlMapper;
using d01ApiV2.Common.Configuration;

namespace d01ApiV2.DbFactory.Implementation
{
    public abstract class BaseDbFactory
    {

        private readonly IDbConnection _dbConnection;
        protected readonly DbFactoryConfiguration DbFactoryConfiguration;

        public abstract string ConnectionString { get; }

        protected BaseDbFactory(IOptions<DbFactoryConfiguration> dbFactoryConfiguration)
        {
            DbFactoryConfiguration = dbFactoryConfiguration.Value;
            _dbConnection = new SqlConnection(ConnectionString);
        }

        public async Task<Tuple<IEnumerable<T1>, T2>> ExecuteQueryMultipleReturnAsync<T1, T2>(string storedprocedure, object parameter)
        {
            using (var conn = _dbConnection)
            {
                using (var multiResult = await conn.QueryMultipleAsync(storedprocedure, parameter, commandType: CommandType.StoredProcedure).ConfigureAwait(false))
                {
                    return new Tuple<IEnumerable<T1>, T2>(
                            await multiResult.ReadAsync<T1>().ConfigureAwait(false),
                            await multiResult.ReadSingleAsync<T2>().ConfigureAwait(false)
                        );

                }
            }
        }

        public async Task<Tuple<IEnumerable<T1>, T2, T3>> ExecuteQueryPaginationReturnAsync<T1, T2, T3>(string storedprocedure, object parameter)
        {
            using (var conn = _dbConnection)
            {
                using (var multiResult = await conn.QueryMultipleAsync(storedprocedure, parameter, commandType: CommandType.StoredProcedure).ConfigureAwait(false))
                {
                    return new Tuple<IEnumerable<T1>, T2, T3>(
                            await multiResult.ReadAsync<T1>().ConfigureAwait(false),
                            await multiResult.ReadSingleAsync<T2>().ConfigureAwait(false),
                            await multiResult.ReadSingleAsync<T3>().ConfigureAwait(false)
                        );

                }
            }
        }

        public async Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, T3>> ExecuteQueryGetPageObjectAsync<T1, T2, T3>(string storedprocedure, object parameter)
        {
            using (var conn = _dbConnection)
            {
                using (var multiResult = await conn.QueryMultipleAsync(storedprocedure, parameter, commandType: CommandType.StoredProcedure).ConfigureAwait(false))
                {
                    return new Tuple<IEnumerable<T1>, IEnumerable<T2>, T3>(
                            await multiResult.ReadAsync<T1>().ConfigureAwait(false),
                            await multiResult.ReadAsync<T2>().ConfigureAwait(false),
                            await multiResult.ReadSingleAsync<T3>().ConfigureAwait(false)
                        );

                }
            }
        }

        public async Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, T3>> ExecuteQueryMultipleReturnAsync<T1, T2, T3>(string storedprocedure, object parameter)
        {
            using (var conn = _dbConnection)
            {
                using (var multiResult = await conn.QueryMultipleAsync(storedprocedure, parameter, commandType: CommandType.StoredProcedure).ConfigureAwait(false))
                {
                    return new Tuple<IEnumerable<T1>, IEnumerable<T2>, T3>(
                            await multiResult.ReadAsync<T1>().ConfigureAwait(false),
                            await multiResult.ReadAsync<T2>().ConfigureAwait(false),
                            await multiResult.ReadSingleAsync<T3>().ConfigureAwait(false)
                        );

                }
            }
        }

        public async Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, T3, T4>> ExecuteQueryMultipleReturnAsync<T1, T2, T3, T4>(string storedprocedure, object parameter)
        {
            using (var conn = _dbConnection)
            {
                using (var multiResult = await conn.QueryMultipleAsync(storedprocedure, parameter, commandType: CommandType.StoredProcedure).ConfigureAwait(false))
                {
                    return new Tuple<IEnumerable<T1>, IEnumerable<T2>, T3, T4>(
                            await multiResult.ReadAsync<T1>().ConfigureAwait(false),
                            await multiResult.ReadAsync<T2>().ConfigureAwait(false),
                            await multiResult.ReadSingleAsync<T3>().ConfigureAwait(false),
                            await multiResult.ReadSingleAsync<T4>().ConfigureAwait(false)
                        );

                }
            }
        }

        public async Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, T4, T5>> ExecuteQueryMultipleReturnAsync<T1, T2, T3, T4, T5>(string storedprocedure, object parameter)
        {
            using (var conn = _dbConnection)
            {
                using (var multiResult = await conn.QueryMultipleAsync(storedprocedure, parameter, commandType: CommandType.StoredProcedure).ConfigureAwait(false))
                {
                    return new Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, T4, T5>(
                            await multiResult.ReadAsync<T1>().ConfigureAwait(false),
                            await multiResult.ReadAsync<T2>().ConfigureAwait(false),
                            await multiResult.ReadAsync<T3>().ConfigureAwait(false),
                            await multiResult.ReadSingleAsync<T4>().ConfigureAwait(false),
                            await multiResult.ReadSingleAsync<T5>().ConfigureAwait(false)
                        );

                }
            }
        }

        public async Task<Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, T6>> ExecuteQueryMultipleReturnAsync<T1, T2, T3, T4, T5, T6>(string storedprocedure, object parameter)
        {
            using (var conn = _dbConnection)
            {
                using (var multiResult = await conn.QueryMultipleAsync(storedprocedure, parameter, commandType: CommandType.StoredProcedure).ConfigureAwait(false))
                {
                    return new Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, T6>(
                            await multiResult.ReadAsync<T1>().ConfigureAwait(false),
                            await multiResult.ReadAsync<T2>().ConfigureAwait(false),
                            await multiResult.ReadAsync<T3>().ConfigureAwait(false),
                            await multiResult.ReadAsync<T4>().ConfigureAwait(false),
                            await multiResult.ReadAsync<T5>().ConfigureAwait(false),
                            await multiResult.ReadSingleAsync<T6>().ConfigureAwait(false)
                        );

                }
            }
        }

    }
}
