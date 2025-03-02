using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni_DotNet_Practics3;

namespace TestProject_Practics3
{
    public class PrimeCheckerTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(4, false)]
        [InlineData(13, true)]
        public void IsPrime_ReturnsCorrectly(int number, bool expected)
        {
            var primeChecker = new PrimeChecker();
            var result = primeChecker.IsPrime(number);

            Assert.Equal(expected, result);
        }
    }

}
