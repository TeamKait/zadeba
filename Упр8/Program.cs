using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнили Лющенко Артём, Владислав Дерин\n");
            while(true)
            {
                var input = Console.ReadLine();
                if(input.ToLower() == "q")
                {
                    break;
                }
                var output = Calculator.ThirdPower(float.Parse(input)).ToString().Split(',');
                Console.WriteLine("Дробная часть: " + output[output.Length - 1]);
            }
        }
    }
    public class Calculator
    {
        public static float ThirdPower(float num)
        {
            return num * num * num;
        }
    }
}
