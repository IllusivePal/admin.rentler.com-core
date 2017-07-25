using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using ServiceStack.Redis;

namespace Rentler.Cache.Redis
{
    public class RedisCache
    {
        private RedisConfig _redisConfig { get; }
        private RedisClient GetRedisClient()
        {
            if (string.IsNullOrEmpty(_redisConfig.RedisAuth))
                return new RedisClient(_redisConfig.RedisHost, _redisConfig.RedisPort);

            else
                return new RedisClient(_redisConfig.RedisHost, _redisConfig.RedisPort, _redisConfig.RedisAuth);
        }
        public RedisCache(IOptions<RedisConfig> redisConf)
        {
            _redisConfig = redisConf.Value;

        }
        public Task Increment(string key)
        {
            return Task.Factory.StartNew(() => {
                using (var redisClient = GetRedisClient())
                {
                    redisClient.Db = _redisConfig.RedisAtomicDatabase;
                    redisClient.Incr(key);
                }
            });
        }
        public Task Decrement(string key)
        {
            return Task.Factory.StartNew(() =>
            {
                using (var redisClient = GetRedisClient())
                {
                    redisClient.Db = _redisConfig.RedisAtomicDatabase;
                    redisClient.Decr(key);
                }
            });
        }
        public Task SetKey(string key, byte[] value, TimeSpan? expiration = null)
        {
            return Task.Factory.StartNew(() =>
            {
                using (var redisClient = GetRedisClient())
                {
                    redisClient.Db = _redisConfig.RedisCacheDatabase;
                    if (expiration.HasValue)
                    {
                        redisClient.Set(key, value, expiration.Value);
                    }
                    else
                    {
                        redisClient.Set(key, value);
                    }
                }
            });
        }
        public Task SetKey(string key, string value, TimeSpan? expiration = null)
        {
            return SetKey(key, Encoding.ASCII.GetBytes(value), expiration);
        }
        public Task<byte[]> Get(string key)
        {
            return Task<byte[]>.Factory.StartNew(() =>
            {
                using (var redisClient = GetRedisClient())
                {
                    redisClient.Db = _redisConfig.RedisCacheDatabase;
                    return redisClient.Get(key);
                }
            });
        }
        public Task<string> GetString(string key)
        {
            return Task<string>.Factory.StartNew(() =>
            {
                using (var redisClient = GetRedisClient())
                {
                    redisClient.Db = _redisConfig.RedisCacheDatabase;
                    byte[] result = redisClient.Get(key);
                    if (result == null || result.Length == 0)
                        return string.Empty;
                    return Encoding.ASCII.GetString(result);
                }
            });
        }
        public Task<List<string>> GetStrings(string pattern)
        {
            var test = _redisConfig.RedisHost;
            var port = _redisConfig.RedisPort;

            return Task<List<string>>.Factory.StartNew(() =>
            {
                using (var redisClient = GetRedisClient())
                {
                    redisClient.Db = _redisConfig.RedisCacheDatabase;
                    return redisClient.GetValues(redisClient.SearchKeys(pattern));
                }
            });
        }
        public Task Remove(string key)
        {
            return Task.Factory.StartNew(() =>
            {
                using (var redisClient = GetRedisClient())
                {
                    redisClient.Db = _redisConfig.RedisCacheDatabase;
                    redisClient.Remove(key);
                }
            });
        }
        public Task<byte[]> GetAtomic(string key)
        {
            return Task<byte[]>.Factory.StartNew(() =>
            {
                using (var redisClient = GetRedisClient())
                {
                    redisClient.Db = _redisConfig.RedisAtomicDatabase;
                    return redisClient.Get(key);
                }
            });
        }
        public Task<string> GetAtomicString(string key)
        {
            return Task<string>.Factory.StartNew(() =>
            {
                using (var redisClient = GetRedisClient())
                {
                    redisClient.Db = _redisConfig.RedisAtomicDatabase;
                    byte[] result = redisClient.Get(key);
                    if (result == null || result.Length == 0)
                        return string.Empty;
                    return Encoding.ASCII.GetString(result);
                }
            });
        }
        public Task<byte[]> GetHashItem(string key, string item)
        {
            return Task<byte[]>.Factory.StartNew(() =>
            {
                using (var redisClient = GetRedisClient())
                {
                    redisClient.Db = _redisConfig.RedisAtomicDatabase;
                    byte[] response = redisClient.HGet(key, Encoding.ASCII.GetBytes(item));

                    if (response == null || response.Length == 0)
                        return null;

                    return response;
                }
            });
        }
        public Task RemoveHashItem(string key, string item)
        {
            return Task.Factory.StartNew(() =>
            {
                using (var redisClient = GetRedisClient())
                {
                    redisClient.Db = _redisConfig.RedisAtomicDatabase;
                    redisClient.HDel(key, Encoding.ASCII.GetBytes(item));
                }
            });
        }

    }
}
