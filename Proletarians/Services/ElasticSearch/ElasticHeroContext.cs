using Cellula.Heroes;
using Microsoft.Extensions.Configuration;
using Nest;
using Proletarians.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proletarians.Services.ElasticSearch
{
    public class ElasticHeroContext : ElasticClient, IElasticContext
    {
        public async Task<CreateIndexResponse> CreateIndex()
        {
            try
            {
                var settings = new ConnectionSettings(new Uri(ProjectUtility.Instance.GetElasticConnection())).DefaultMappingFor<Characters>(c => c.IdProperty(d => d.Id));
                var client = new ElasticClient(settings);
                var result = await client.Indices.CreateAsync("heroes", m => m.Map<Characters>(c => c.AutoMap()));
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
