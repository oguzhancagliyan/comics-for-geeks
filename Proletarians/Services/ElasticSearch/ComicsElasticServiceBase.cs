using Nest;
using Proletarians.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proletarians.Services.ElasticSearch
{
    public abstract class ComicsElasticServiceBase<TDocument> : IComicsElasticBase<TDocument> where TDocument : class, new()
    {
        private readonly IElasticContext _elasticContext;
        private string currentIndex = string.Empty;
        public ComicsElasticServiceBase(IElasticContext elasticContext)
        {
            _elasticContext = elasticContext;
            currentIndex = typeof(TDocument).Name.ToLower();
        }
        public Result Add(TDocument doc)
        {
            try
            {                                
                var result = _elasticContext.Index(doc, idx => idx.Index(currentIndex));
                return result.Result;
            }
            catch (Exception)
            {
                return default;
            }
        }

        public async Task<Result> AddAsync(TDocument doc)
        {
            try
            {
                var result = await _elasticContext.IndexAsync(doc, a => a.Index(currentIndex));
                return result.Result;
            }
            catch (Exception ex)
            {
                return Result.Noop;
            }
        }

        public BulkResponse BulkAdd(List<TDocument> docs)
        {
            try
            {
                var result = _elasticContext.IndexMany(docs, currentIndex);
                return result;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<BulkResponse> BulkAddAsync(List<TDocument> docs)
        {
            try
            {
                var result = await _elasticContext.IndexManyAsync(docs, currentIndex);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public BulkResponse BulkDelete(List<int> Ids)
        {
            try
            {
                List<TDocument> documents = new List<TDocument>();
                Ids.ForEach(a =>
                {
                    var resultFromGet = _elasticContext.Get<TDocument>(a);
                    documents.Add(resultFromGet.Source);
                });
                var bulkDeleteResult = _elasticContext.DeleteMany(documents, currentIndex);
                return bulkDeleteResult;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Result Delete(int Id)
        {
            try
            {
                var result = _elasticContext.Delete<TDocument>(Id, a => a.Index(currentIndex));
                return result.Result;
            }
            catch (Exception)
            {
                return Result.Noop;
            }
        }

        public async Task<Result> DeleteAsync(int Id)
        {
            try
            {
                var result = await _elasticContext.DeleteAsync<TDocument>(Id, a => a.Index(currentIndex));
                return result.Result;
            }
            catch (Exception)
            {
                return Result.Noop;
            }
        }

        public bool Exist(int Id)
        {
            try
            {
                var result = _elasticContext.DocumentExists<TDocument>(Id);
                return result.Exists;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> ExistAsync(int Id)
        {
            try
            {
                var result = await _elasticContext.DocumentExistsAsync<TDocument>(Id);
                return result.Exists;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public TDocument Get(int Id)
        {
            try
            {
                var result = _elasticContext.Get<TDocument>(Id);
                return result.Source;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<TDocument> GetAsync(int Id)
        {
            try
            {
                var result = await _elasticContext.GetAsync<TDocument>(Id);
                return result.Source;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<List<TDocument>> SearchAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Result Update(int Id, TDocument document)
        {
            try
            {
                var result = _elasticContext.Update<TDocument>(Id, a => a.Upsert(document));
                return result.Result;
            }
            catch (Exception)
            {
                return Result.Noop;
            }
        }

        public async Task<Result> UpdateAsync(long Id, TDocument partial)
        {
            try
            {

                var result = await _elasticContext.UpdateAsync<TDocument>(Id, a => a.Upsert(partial));
                return result.Result;
            }
            catch (Exception)
            {
                return Result.Noop;
            }
        }

        public async Task<BulkResponse> UpdateBulkAsync(Dictionary<long, TDocument> keyValuePairs)
        {

            return null;
        }
    }
}
