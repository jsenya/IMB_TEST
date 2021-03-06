﻿using IMB_TEST.Core.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMB_TEST.Core.Services
{
    public class HelperService : IHelperService
    {
		public int FindIndex<T>(T item, IEnumerable<T> items)
		{
			try
			{
				for (var i = 0; i <= items.Count(); i++)
					if (item.Equals(i)) return i;
				return -1;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public bool IsPrime(int num)
        {
			try
			{
				for (var i = 2; i < num; i++)
					if (num % i == 0) return false;
				return true;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		public Func<T, K> Memoize<T, K>(Func<T, K> localFunc)
		{
			try
			{
				var cache = new Dictionary<T, K>();
				return val =>
				{
					K value;
					if (cache.TryGetValue(val, out value))
						return value;
					value = localFunc(val);
					cache.Add(val, value);
					return value;
				};
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public Func<int, bool> MemoizedIsPrime()
			=> Memoize(new Func<int, bool>(IsPrime));
	}
}
