using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uni_DotNet_Practics3;

namespace TestProject_Practics3
{
    public class StringReverserTests
    {
        [Theory]
        [InlineData("hello", "olleh")]
        [InlineData("world", "dlrow")]
        public void ReverseString_ReturnsReversedString(string input, string expected)
        {
            var reverser = new StringReverser();
            var result = reverser.ReverseString(input);

            Assert.Equal(expected, result);
        }
    }

}
