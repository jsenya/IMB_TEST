using IMB_TEST.Core.Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static IMB_TEST.Core.Test.Constants;

namespace IMB_TEST.Core.Test.Services
{
    public class HelperServiceTests
    {
        private readonly int[] items = new int[] { 1, 3, 2, 0 };

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrimeShouldReturnTrue(int num)
        {
            //arrange
            IHelperService _service = GetHelperService();

            //act
            bool isPrime = _service.IsPrime(num);

            //assert
            Assert.True(isPrime);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void MemoizeIsPrimeShouldReturnTrue(int num)
        {
            //arrange
            IHelperService _service = GetHelperService();
            var memoizedPrime = _service.MemoizedIsPrime();

            //act
            bool isPrime = memoizedPrime(num);

            //assert
            Assert.True(isPrime);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        public void IsPrimeShouldReturnFalse(int num)
        {
            //arrange
            IHelperService _service = GetHelperService();

            //act
            bool isPrime = _service.IsPrime(num);

            //assert
            Assert.False(isPrime);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        public void MemoizeIsPrimeShouldReturnFalse(int num)
        {
            //arrange
            IHelperService _service = GetHelperService();
            var memoizedPrime = _service.MemoizedIsPrime();

            //act
            bool isPrime = memoizedPrime(num);

            //assert
            Assert.False(isPrime);
        }

        [Fact]
        public void Memoize()
        {
            //arrange
            IHelperService _service = GetHelperService();

            //act
            var result = _service.Memoize(new Func<int, bool>(_service.IsPrime));

            //assert
            Assert.NotNull(result);
            Assert.True(result is Func<int, bool>);
        }

        [Theory, InlineData(2)]
        public void FindIndexReturnIndex(int item)
        {
            //arrange
            IHelperService _service = GetHelperService();

            //act
            var result = _service.FindIndex<int>(item, items);

            //assert
            Assert.True(result == 2);
        }

        [Theory, InlineData(7)]
        public void FindIndexReturnNegativeOne(int item)
        {
            //arrange
            IHelperService _service = GetHelperService();

            //act
            var result = _service.FindIndex<int>(item, items);

            //assert
            Assert.True(result == -1);
        }
    }
}
