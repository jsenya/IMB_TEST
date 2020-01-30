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
        [InlineData(4)]
        [InlineData(6)]
        public async Task IsPrimeShouldReturnFalse(int num)
        {
            //arrange
            IHelperService _service = GetHelperService();

            //act
            bool isPrime = await _service.IsPrimeAsync(num);

            //assert
            Assert.False(isPrime);
        }
    }
}
