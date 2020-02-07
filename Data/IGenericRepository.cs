using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace demo.Data
{
    public interface IGenericRepository
    {
        Task<T> CommandAsync<T>(Func<SqlConnection, SqlTransaction, int, Task<T>> command);
        Task<T> GetAsync<T>(Func<SqlConnection, SqlTransaction, int, Task<T>> command);
        Task<IList<T>> SelectAsync<T>(Func<SqlConnection, SqlTransaction, int, Task<IList<T>>> command);
        Task ExecuteAsync(string sql, object parameters);
        Task<T> GetAsync<T>(string sql, object parameters);
        Task<IList<T>> SelectAsync<T>(string sql, object parameters);
    }
}