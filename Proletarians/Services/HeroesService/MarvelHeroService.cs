using Cellula.Dtos.HeroesDtos.Marvel;
using Microsoft.Extensions.Configuration;
using Proletarians.Interfaces;
using Proletarians.Utility;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Cellula.Comics;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace Proletarians.Services
{
    public class MarvelHeroService : IHeroRequestBase<MarvelHeroRequestDto, List<MarvelHeroResponseDto>>
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IConfiguration _configuration;
        public MarvelHeroService(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }
        public List<MarvelHeroResponseDto> GetHero(MarvelHeroRequestDto heroBaseRequestDto)
        {
            return null;
        }

        public async Task<List<MarvelHeroResponseDto>> SearchHero(string name)
        {


            try
            {
                var timeStamp = DateTime.Now.GetTimeStamp();
                var computedHash = $"{timeStamp}{_configuration.GetValue<string>("Keys:MarvelPrivateKey")}{_configuration.GetValue<string>("Keys:MarvelPublicKey")}".GetMd5HashData();
                var httpclient = _clientFactory.CreateClient("marvelBase");
                var result = await httpclient.GetAsync($"/v1/public/characters?nameStartsWith={name}&ts={timeStamp}&apikey={_configuration.GetValue<string>("Keys:MarvelPublicKey")}&hash={computedHash}");

                var result2 = JsonConvert.DeserializeObject<MarvelResponse>(await result.Content.ReadAsStringAsync());
                if (result.IsSuccessStatusCode)
                {
                    return result2.Data.Results.Select(b => new MarvelHeroResponseDto { MarvelName = b.Name }).ToList();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
