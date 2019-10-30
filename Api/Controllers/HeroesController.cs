using System.Collections.Generic;
using System.Threading.Tasks;
using Cellula.Dtos.HeroesDtos.Marvel;
using Microsoft.AspNetCore.Mvc;
using Proletarians.Interfaces;
using System.Linq;
namespace Api.Controllers
{
    [Route("heroes")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private readonly IHeroRequestBase<MarvelHeroRequestDto, List<MarvelHeroResponseDto>> _heroRequestBase;
        public HeroesController(IHeroRequestBase<MarvelHeroRequestDto, List<MarvelHeroResponseDto>> heroRequestBase)
        {
            _heroRequestBase = heroRequestBase;
        }
        // GET: api/Heroes
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var result = await _heroRequestBase.SearchHero("spi");
            return result.Select(b => b.MarvelName);
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
