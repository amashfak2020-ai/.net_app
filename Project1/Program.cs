using System;

namespace Project1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Project1!");
            Console.WriteLine("This is a simple .NET console application.");
            int result = Add(5, 3);
            Console.WriteLine($"5 + 3 = {result}");
        }

        public static int Add(int a, int b) {
            return a + b;
        }

        public static int Subtract(int a, int b) {
            return a - b;
        }

        public static int Multiply(int a, int b) {
            return a * b;
        }
    }
}