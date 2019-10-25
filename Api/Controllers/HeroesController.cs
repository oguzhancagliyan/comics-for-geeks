using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cellula.Dtos.HeroesDtos.Marvel;
using Cellula.Heroes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proletarians.Interfaces;

namespace Api.Controllers
{
    [Route("heroes")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private readonly IHeroRequestBase<MarvelHeroRequestDto, MarvelHeroResponseDto> _heroRequestBase;
        public HeroesController(IHeroRequestBase<MarvelHeroRequestDto, MarvelHeroResponseDto> heroRequestBase)
        {
            _heroRequestBase = heroRequestBase;
        }
        // GET: api/Heroes
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = _heroRequestBase.SearchHero("spi");
            return new string[] { "value1", "value2" };
        }

        // GET: api/Heroes/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Heroes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Heroes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        //[HttpGet]
        //public async Task<IEnumerable<Characters>> Search(string name)
        //{
        //    var result = _heroRequestBase.SearchHero(name);
        //    return null;
        //}
    }
}
