using Cellula.Dtos.HeroesDtos.Marvel;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Proletarians.Interfaces;
using Proletarians.Utility;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proletarians.Services
{
    public class MarvelHeroService : IHeroRequestBase<MarvelHeroRequestDto, MarvelHeroResponseDto>
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IConfiguration _configuration;
        public MarvelHeroService(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }
        public MarvelHeroResponseDto GetHero(MarvelHeroRequestDto heroBaseRequestDto)
        {
            return null;
        }

        public async Task<MarvelHeroResponseDto> SearchHero(string name)
        {


            var timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            var computedHash = $"{timeStamp}{_configuration.GetValue<string>("Keys:MarvelPrivateKey")}{_configuration.GetValue<string>("Keys:MarvelPublicKey")}".GetMd5HashData();
            var client = new RestClient("https://gateway.marvel.com");
            var request = new RestRequest("/v1/public/characters", Method.GET);




            var httpclient = _clientFactory.CreateClient("marvel");
            var content = new FormUrlEncodedContent(new KeyValuePair<string, string>[]
            {
            new KeyValuePair<string, string>("nameStartsWith", name),
            new KeyValuePair<string, string>("ts", timeStamp),
            new KeyValuePair<string, string>("apikey",_configuration.GetValue<string>("Keys:MarvelPublicKey")),
            new KeyValuePair<string, string>("hash",computedHash),
            });
            await httpclient.SendAsync(new HttpRequestMessage
            {
                Content = content,
                Method = HttpMethod.Get,
                RequestUri = new Uri("/v1/public/characters"),
                Properties
            });








            request.AddParameter("nameStartsWith", name);
            request.AddParameter("ts", timeStamp);
            request.AddParameter("apikey", _configuration.GetValue<string>("Keys:MarvelPublicKey"));
            request.AddParameter("hash", computedHash);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            var rr = client.Execute<List<Cellula.Heroes.Characters>>(request);

            return null;
        }
    }
}
