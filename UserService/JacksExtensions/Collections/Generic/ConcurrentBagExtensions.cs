using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksExtensions.Collections.Generic
{
	public static class ConcurrentBagExtensions
	{
		public static void Purge<T>(this ConcurrentBag<T> bag)
		{
			T itemRemoved;

			if (bag.Count > 0)
			{
				while (bag.TryTake(out itemRemoved)) { }
			}
		}
	}
}
