using System;
using System.Collections.Generic;
using System.Text;

namespace Rentler.Cache.Redis
{
    public class RedisConfig
    {
        public string RedisHost { get; set; }
        public string RedisAuth { get; set; }
        public int RedisPort { get; set; }
        public int RedisAtomicDatabase { get; set; }
        public int RedisCacheDatabase { get; set; }
        public string Hostname { get; set; }
        public string ListingLocation { get; set; }
        public string DotComHostname { get; set; }
    }
}
