using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнили Лющенко Артём, Владислав Дерин");
            string even = "";
            string odd = "";
            for (int i = 0; i < 20; i++) {
                if(i%2 == 0)
                {
                    even += i + (i != 18 ? ", " : "");
                }
                else
                {
                    odd += i + (i != 19 ? ", " : "");
                }
            }
            Console.WriteLine("\nЧётные\n" + even);
            Console.WriteLine("\nНечётные\n" + odd);

            int inputNumber = Int32.Parse(Console.ReadLine());
            string stringMultiplier = "";
            for(int i = 1; i <= inputNumber; i++)
            {
                if(i%3 == 0 && inputNumber%i==0)
                {
                    stringMultiplier += i + (i != inputNumber ? ", " : "");
                }
            }
            Console.WriteLine("\nМножители кратные 3:\n" + stringMultiplier);

            string factorString = "";
            while(inputNumber != 1)
            {
                int currentFactor = 2;
                while(inputNumber % currentFactor != 0)
                {
                    currentFactor++;
                }
                inputNumber /= currentFactor;
                factorString += currentFactor + (inputNumber != 1 ? ", " : "");
            }
            Console.WriteLine("\nСомножители введённого числа:\n" + factorString);
        }
    }
}
