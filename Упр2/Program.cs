using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнил Лющенко Артём, Владислав Дерин");
            double x = 3.14;
            string currentString = "";
            for(int i = 0; i < 5; i++)
            {
                currentString += x + "\t";
                x += 0.01;
            }
            x = 3.14;
            currentString += "\n";
            for (int i = 0; i < 5; i++)
            {
                currentString += Math.Round(x * x, 2) + "\t";
                x += 0.01;
            }
            x = 3.14;
            currentString += "\n";
            for (int i = 0; i < 5; i++)
            {
                currentString += Math.Round(x * x * x, 2) + "\t";
                x += 0.01;
            }
            Console.WriteLine(currentString);
            Console.ReadKey();
        }
    }
}
