using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMB_TEST.Core.Services.IServices
{
    public interface IHelperService
    {
        bool IsPrime(int num);
        Func<T, K> Memoize<T, K>(Func<T, K> localFunc);
        Func<int, bool> MemoizedIsPrime();

        //QUESTION 2
        int FindIndex<T>(T item, IEnumerable<T> items);
    }
}
