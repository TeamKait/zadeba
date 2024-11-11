using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнили: Лющенко Дерин ИСП211");
            Console.WriteLine("Введите N: ");

            int n = int.Parse( Console.ReadLine());

            Console.WriteLine("Recursive: " + factorialRecursive(n));
            Console.WriteLine("Iteral: " + factorialIteral(n));
        }
        static int factorialRecursive(int n)
        {
            if(n == 1)
            {
                return 1;
            }

            return n * factorialRecursive(n-1);
        }
        static int factorialIteral(int n)
        {
            int result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
