using Cellula.Dtos.HeroesDtos;
using Cellula.Dtos.HeroesDtos.Marvel;
using Proletarians.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proletarians.Services
{
    public class MarvelHeroService : IHeroRequestBase<MarvelHeroRequestDto, MarvelHeroResponseDto>
    {
        //private readonly IHttpClientFactory 
        public MarvelHeroService()
        {

        }
        public MarvelHeroResponseDto GetHero(MarvelHeroRequestDto heroBaseRequestDto)
        {
            return null;
        }

        public MarvelHeroResponseDto SearchHero(string name)
        {
            
        }
    }
}
