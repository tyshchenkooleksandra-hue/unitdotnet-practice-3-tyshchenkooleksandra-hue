using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni_DotNet_Practics3;

namespace TestProject_Practics3
{
    public class SumCalculatorTests
    {
        [Theory]
        [InlineData(10, 30)]
        [InlineData(5, 6)]
        public void SumOfEvens_ReturnsCorrectSum(int n, int expected)
        {
            var calculator = new SumCalculator();
            var result = calculator.SumOfEvens(n);

            Assert.Equal(expected, result);
        }
    }

}
