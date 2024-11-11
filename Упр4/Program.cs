using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Числа, делящиеся на 4, 7 и 11: ");
            for (int i = 1; i <= 3000; i++)
            {
                if (i % 4 == 0 && i % 7 == 0 && i % 11 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            Console.Write("Простые числа: ");
            int countPrimes = 0;
            for (int i = 2; i <= 3000; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                    countPrimes++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество простых чисел: {0}", countPrimes);
        }
    }
}
