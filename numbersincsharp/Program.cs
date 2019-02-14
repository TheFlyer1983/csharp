using System;

namespace numbersincsharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            Console.WriteLine("Working with Integers");
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
            c = a + b - 12 * 17;
            Console.WriteLine(c);
        }
        static void OrderPrecedent()
        {
          Console.WriteLine("Order Precedent");
          int a = 5;
          int b = 4;
          int c = 2;
          int d = a + b * c;
          Console.WriteLine(d);
          d = (a + b) * c;
          Console.WriteLine(d);
          d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
          Console.WriteLine(d);
          //When dividing by an integer, you get an integer as a result.
          int e = 7;
          int f = 4;
          int g = 3;
          int h = (e + f) / g;
          Console.WriteLine(h);
        }

        static void TestLimits()
        {
          Console.WriteLine("Test Limits");
          int a = 7;
          int b = 4;
          int c = 3;
          int d = (a + b) / c;
          int e = (a + b) % c;
          Console.WriteLine($"quotient: {d}");
          Console.WriteLine($"remainder: {e}");

          int max = int.MaxValue;
          int min = int.MinValue;
          Console.WriteLine($"The range of intger is {min} to {max}");

          int what = max + 3;
          Console.WriteLine($"An example of overflow: {what}");
        }
        static void Main(string[] args)
        {
          //WorkingWithIntegers();
          //OrderPrecedent();
          //TestLimits();

          double a = 5;
          double b = 4;
          double c = 2;
          double d = (a + b) / c;
          Console.WriteLine(d);
          double e = 19;
          double f = 23;
          double g = 8;
          double h = (e + f) / g;
          Console.WriteLine(h);
          double max = double.MaxValue;
          double min = double.MinValue;
          Console.WriteLine($"The range of double is {min} to {max}");
          double third = 1.0 / 3.0;
          Console.WriteLine(third);
        }
    }
}
