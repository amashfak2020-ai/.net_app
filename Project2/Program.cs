using System;

namespace Project2 {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine(GetGreeting("World"));
            Console.WriteLine("Factorial of 5: " + CalculateFactorial(5));
            Console.WriteLine("Is 7 prime? " + IsPrime(7));
        }

        public static string GetGreeting(string name) {
            return $"Hello, {name}!";
        }

        public static int CalculateFactorial(int number) {
            if (number <= 1) return 1;
            return number * CalculateFactorial(number - 1);
        }

        public static bool IsPrime(int number) {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++) {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}