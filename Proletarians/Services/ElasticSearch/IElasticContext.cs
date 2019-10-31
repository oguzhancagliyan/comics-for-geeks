using Nest;
using System.Threading.Tasks;

namespace Proletarians.Services.ElasticSearch
{
    public interface IElasticContext : IElasticClient
    {
        Task<CreateIndexResponse> CreateIndex();
    }
}
