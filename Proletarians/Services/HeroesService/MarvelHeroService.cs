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
        public MarvelHeroResponseDto GetHero(MarvelHeroRequestDto heroBaseRequestDto)
        {
            return null;
        }
    }
}
