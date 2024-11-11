using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр9
{
    public class Calculator
    {
        public double Root(double num, double pow)
        {
            return Math.Pow(num, 1 / pow);
        }
        public double Z_(double x, double y)
        {
            double e = Math.E;
            double denumerator = e * e - Math.Pow(x + y, 3 / 4);
            if(denumerator < 0)
            {
                Utils.PrintError("извлечение корня из отрицательного числа");
                return double.NaN;
            }
            denumerator = Root(denumerator, 3);
            if(denumerator == 0)
            {
                Utils.PrintError("попытка деления на ноль");
                return double.NaN;
            }

            double first = x / denumerator;
            if (x - y == 0 && Math.Sin(x * y) < 0) {
                Utils.PrintError("попытка деления на ноль");
                return double.NaN;
            }
            double second = Math.Pow(x - y, Math.Sin(x * y));
            second = Math.Pow(second, 7 / 3);
            second /= denumerator;

            return first + second;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Utils.PrintAuthors();
            double x = Utils.Input<double>("x");
            double y = Utils.Input<double>("y");

            Calculator calc = new Calculator();
            double result = calc.Z_(x, y);
            if (!(result < double.PositiveInfinity)) result = double.NaN;

            if (!double.IsNaN(result))
            {
                result.Output("результат");
            }
            else
            {
                Console.WriteLine("Решения нет");
            }
        }
    }
}
