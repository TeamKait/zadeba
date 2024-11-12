using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace упр10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utils.PrintAuthors();
            double degree = Utils.Input<double>("значение угла в градусах");
            double radians = degree / 180 * Math.PI;
            Console.WriteLine($"sin({degree})={Math.Round(Math.Sin(radians), 1)}\tcos({degree})={Math.Round(Math.Cos(radians), 1)}\ttg({degree})={Math.Round(Math.Tan(radians), 1)}\n");

            double X = Utils.Input<double>("X");
            double Y = Utils.Input<double>("Y");

            Console.Write($"\nexp({X})={Math.Round(Math.Exp(X), 2)}");
            Console.Write($"\tlog({X})={Math.Round(Math.Log(X), 2)}");
            Console.Write($"\tlog10({X})={Math.Round(Math.Log10(X), 2)}");
            Console.Write($"\tpow({X} , {Y})={Math.Round(Math.Pow(X, Y), 2)}");
            Console.Write($"\nsqrt({X})={Math.Round(Math.Sqrt(X), 2)}");
            Console.Write($"\tabs({X})={Math.Round(Math.Abs(X), 2)}");
            Console.Write($"\t{X}*2^{Y}={Math.Round(X*Math.Pow(2, Y))}");
            Console.Write($"\tостаток {X}/{Y}={Math.Round(X % Y, 2)}");
        }
    }
}
