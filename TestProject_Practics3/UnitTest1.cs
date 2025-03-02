using Uni_DotNet_Practics3;
namespace TestProject_Practics3
{
    public class FizzBuzzTests
    {
        [Fact]
        public void RunFizzBuzz_ReturnsFizz()
        {
            var fizzBuzz = new FizzBuzz();
            var results = fizzBuzz.RunFizzBuzz();

            Assert.Equal("Fizz", results[2]);
            
        }
        
        [Fact]
        public void RunFizzBuzz_ReturnsCorrectBuzz()
        {
            var fizzBuzz = new FizzBuzz();
            var results = fizzBuzz.RunFizzBuzz();

            Assert.Equal("Buzz", results[4]);
            
        }

        [Fact]
        public void RunFizzBuzz_ReturnsFizzBuzz()
        {
            var fizzBuzz = new FizzBuzz();
            var results = fizzBuzz.RunFizzBuzz();

            Assert.Equal("FizzBuzz", results[14]);
            
        }

        [Fact]
        public void RunFizzBuzz_ReturnsString()
        {
            var fizzBuzz = new FizzBuzz();
            var results = fizzBuzz.RunFizzBuzz();

            Assert.Equal("11", results[10]);
        }

    }

}