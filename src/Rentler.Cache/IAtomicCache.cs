using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Cache
{
    /// <summary>
	/// Cache supporting atomic increments and
	/// atomic decrements. For use with multiple
	/// systems accessing counters in caches at
	/// the same time.
	/// </summary>
    public interface IAtomicCache:ICache
    {
        /// <summary>
		/// Increments the specified key.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <returns>Task result</returns>
		Task Increment(string key);

        /// <summary>
        /// Decrements the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Task result</returns>
        Task Decrement(string key);

        Task<byte[]> GetAtomic(string key);
        Task<string> GetAtomicString(string key);

        Task<byte[]> GetHashItem(string key, string item);
        Task RemoveHashItem(string key, string item);
    }
}
