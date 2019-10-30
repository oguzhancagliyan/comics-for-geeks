using System.Threading.Tasks;

namespace Proletarians.Interfaces
{
    public interface IHeroRequestBase<Tin, TOut>
    {
        TOut GetHero(Tin heroBaseRequestDto);
        Task<TOut> SearchHero(string name);
    }
}
