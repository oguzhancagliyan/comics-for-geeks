using Nest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proletarians.Interfaces
{
    public interface IComicsElasticBase<TDocument> where TDocument : class, new()
    {
        TDocument Get(int Id);
        Result Add(TDocument doc);
        BulkResponse BulkAdd(List<TDocument> docs);
        bool Exist(int Id);
        Result Delete(int Id);
        BulkResponse BulkDelete(List<int> Ids);
        Task<TDocument> GetAsync(int Id);
        Task<Result> AddAsync(TDocument doc);
        Task<BulkResponse> BulkAddAsync(List<TDocument> docs);
        Task<Result> UpdateAsync(long Id, TDocument partial);
        Task<BulkResponse> UpdateBulkAsync(Dictionary<long, TDocument> keyValuePairs);
        Task<Result> DeleteAsync(int Id);
        Task<bool> ExistAsync(int Id);
        Task<List<TDocument>> SearchAsync(string name)
    }
}
