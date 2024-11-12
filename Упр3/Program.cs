using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long i = 95037600125;
            Console.WriteLine("Выполнил Лющенко Артём, Владислав Дерин");
            var charArray = i.ToString().ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(i + " ---> " + new string(charArray));
            Console.WriteLine("Число цифр: " + i.ToString().Split().Length);
            long numSum = 0;
            foreach(char s in i.ToString())
            {
                numSum += Int32.Parse(s.ToString());
            }
            Console.WriteLine("Сумма цифр числа " + i + " равна " + numSum);
            Console.ReadKey();
        }
    }
}
