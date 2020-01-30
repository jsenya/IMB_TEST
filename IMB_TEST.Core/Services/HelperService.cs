using IMB_TEST.Core.Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMB_TEST.Core.Services
{
    public class HelperService : IHelperService
    {
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
    }
}
