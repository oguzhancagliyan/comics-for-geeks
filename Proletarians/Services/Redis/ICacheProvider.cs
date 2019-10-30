using System;
using System.Threading.Tasks;

namespace Proletarians.Services.Redis
{
    public interface ICacheProvider
    {
        Task<T> Get<T>(string key, bool zip) where T : class;

        Task Set<T>(string key, T data, TimeSpan cacheTime, bool zip) where T : class;

        Task Remove(string key);

        Task<bool> Exist(string key);
    }
}
