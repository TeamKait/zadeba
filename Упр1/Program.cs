using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main()
        {
            long number = 9037600125;
            int digitCount = number.ToString().Length;
            char[] digits = number.ToString().ToCharArray();
            Array.Reverse(digits);
            string reversedNumber = new string(digits);
            int digitSum = 0;
            foreach (char digit in digits)
            {
                digitSum += int.Parse(digit.ToString());
            }
            Console.WriteLine($"{number} это перевернутое {reversedNumber}");
            Console.WriteLine($"Число цифр {digitCount}.");
            Console.WriteLine($"Сумма цифр числа {number} равна {digitSum}");
            Console.ReadKey();
        }
    }
}