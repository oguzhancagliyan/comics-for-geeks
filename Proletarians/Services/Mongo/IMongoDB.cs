using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proletarians.Services.Mongo
{
    public interface IMongoDB<T>
    {
        #region Async

        /// <summary>
        /// Get one result from an id
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="id">Id</param>
        /// <returns>T result</returns>
        Task<T> GetAsync(string id);
        /// <summary>
        /// Get all list from MongoDb via async
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <returns>Return all element from DB</returns>
        Task<List<T>> GetAllAsync();
        Task CreateAsync(T instance);
        Task CreateManyAsync(List<T> createList);
        Task UpdateAsync(string id, T instance);
        Task UpdateManyAsync(IDictionary<string, T> updateList);
        Task DeleteAsync(T instance);
        Task DeleteManyAsync(List<T> deleteList);

        Task<List<T>> GetByConditionAsnyc(Expression<Func<T, bool>> expression);
        #endregion
    }
}
