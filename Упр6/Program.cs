using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнили Лющенко Артём, Дерин Владислав\n");
            Console.WriteLine("Введите Х:");
            decimal x = (decimal)Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите Y:");
            decimal y = (decimal)Int32.Parse(Console.ReadLine());
            try
            {
                decimal z1 = (decimal)(((3 * x) / y) - (y / (7 * x)) * ((9 / (x - 1)) - (13 / (y + 1))));
                decimal z2 = (decimal)((x * x + y * y - (x / (2 * y))) / ((y * y - (decimal)2.5) / (x * x + 1)));
                Console.WriteLine("{0:e}", z1);
                Console.WriteLine("{0:e}", z2);
            }
            catch (Exception _)
            {
                Console.WriteLine("Ошибка: попытка деления на 0");
            }

        }
    }
}
