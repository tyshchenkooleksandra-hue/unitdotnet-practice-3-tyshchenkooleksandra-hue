using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni_DotNet_Practics3;

namespace TestProject_Practics3
{
    public class VowelCounterTests
    {
        [Theory]
        [InlineData("Hello World!", 3)]
        [InlineData("Xunit Testing", 4)]
        [InlineData("AEIOUaeiou", 10)]
        public void CountVowels_ReturnsCorrectCount(string input, int expected)
        {
            var vowelCounter = new VowelCounter();
            var result = vowelCounter.CountVowels(input);
            Assert.Equal(expected, result);
        }
    }

}
