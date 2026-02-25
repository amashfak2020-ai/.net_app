using Xunit;

namespace Project3.Tests
{
    public class AdvancedTests
    {
        // Test for Factorial
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(5, 120)]
        public void Factorial_Test(int number, int expected)
        {
            var result = Factorial(number);
            Assert.Equal(expected, result);
        }

        private int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        // Test for Array Operations
        [Fact]
        public void ArraySum_Test()
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var result = ArraySum(arr);
            Assert.Equal(15, result);
        }

        private int ArraySum(int[] arr)
        {
            int sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            return sum;
        }

        // Test for String Reversal
        [Theory]
        [InlineData("hello", "olleh")]
        [InlineData("xUnit", "tInux")]
        public void StringReversal_Test(string input, string expected)
        {
            var result = ReverseString(input);
            Assert.Equal(expected, result);
        }

        private string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Test for Fibonacci Sequence
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(6, 8)]
        public void Fibonacci_Test(int number, int expected)
        {
            var result = Fibonacci(number);
            Assert.Equal(expected, result);
        }

        private int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}