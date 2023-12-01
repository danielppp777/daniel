using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Преобразувател на числа");
            Console.WriteLine("1: Двоично към десетично");
            Console.WriteLine("2: Десетично към двоично");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ConvertBinaryToDecimal();
                    break;
                case 2:
                    ConvertDecimalToBinary();
                    break;
                default:
                    Console.WriteLine("Невалиден избор.");
                    break;
            }
        }

        static void ConvertBinaryToDecimal()
        {
            Console.WriteLine("Въведете двоично число");
            string binaryStr = Console.ReadLine();
            int decimalResult = Convert.ToInt32(binaryStr, 2);
            Console.WriteLine($"Decimal: {decimalResult}");
        }

        static void ConvertDecimalToBinary()
        {
            Console.WriteLine("Въведете десетично число");
            int decimalNum = int.Parse(Console.ReadLine());
            string binaryResult = Convert.ToString(decimalNum, 2);
            Console.WriteLine($"Binary: {binaryResult}");
        }
    }
}
