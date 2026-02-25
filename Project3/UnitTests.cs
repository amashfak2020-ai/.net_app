using Xunit;
namespace Project3 {
    public class UnitTests {
        [Fact]
        public void TestAddition() {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void TestSubtraction() {
            Assert.Equal(0, Subtract(2, 2));
        }
        [Fact]
        public void TestMultiplication() {
            Assert.Equal(4, Multiply(2, 2));
        }
        [Fact]
        public void TestDivision() {
            Assert.Equal(1, Divide(2, 2));
        }
        [Fact]
        public void TestIsPrime() {
            Assert.True(IsPrime(5));
            Assert.False(IsPrime(4));
        }

        private int Add(int a, int b) => a + b;
        private int Subtract(int a, int b) => a - b;
        private int Multiply(int a, int b) => a * b;
        private int Divide(int a, int b) => a / b;

        private bool IsPrime(int number) {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++) {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}