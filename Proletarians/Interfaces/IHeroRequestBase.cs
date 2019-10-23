using Cellula.Dtos.HeroesDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proletarians.Interfaces
{
    public interface IHeroRequestBase<Tin, TOut>
    {
        TOut GetHero(Tin heroBaseRequestDto);
        TOut SearchHero(string name);
    }
}
