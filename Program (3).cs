using System;

namespace ex 1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Double.Parse(Console.ReadLine());

            double area = Math.Round(3.14159 * (r * r), 2);
            double perimeter = Math.Round(2 * 3.14159 * r, 2);

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }
}