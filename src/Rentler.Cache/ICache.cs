using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Rentler.Cache
{
    public interface ICache
    {
        Task SetKey(string key, byte[] value, TimeSpan? expiration = null);
        Task SetKey(string key, string value, TimeSpan? expiration = null);

        Task<byte[]> Get(string key);
        Task<string> GetString(string key);
        Task<List<string>> GetStrings(string pattern);

        Task Remove(string key);

        //  byte[] bytes;
        //  return (bytes = ValueBytes) == null ? null :
        //  bytes.Length == 0 ? "" :
        //  Encoding.UTF8.GetString(bytes);
    }
}
