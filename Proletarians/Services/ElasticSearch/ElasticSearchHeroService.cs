using Cellula.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proletarians.Services.ElasticSearch
{
    public class ElasticSearchHeroService : ComicsElasticServiceBase<Characters>
    {
        public ElasticSearchHeroService(IElasticContext elasticContext) : base(elasticContext)
        {




        }

    }
}
