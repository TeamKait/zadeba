using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр18
{
    public class NumMethods
    {
        public void CubicRoot(ref double x)
        {
            x = Math.Pow(x, 1.0 / 3.0);
        }
        public void SplitNumber(double x, out int intPart, out int floatPart)
        {
            intPart = (int)x;
            double floatBuffer = Math.Round(x - intPart, 12);
            if(floatBuffer > 0)
            {
                floatPart = Int32.Parse(floatBuffer.ToString().Split(',')[1]);
            }
            else
            {
                floatPart = 0;
            }
        }
        public double Max(params double[] values)
        {
            double max = values.Length > 0 ? double.MinValue : 0;
            values.Map(element => { max = max < (double)element ? (double)element : max; });
            return max;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Utils.PrintAuthors();
            NumMethods NM = new NumMethods();

            //cubic root
            double x = Utils.Input<double>("x");
            NM.CubicRoot(ref x);
            x.Output("Кубический корень из x");

            //split number
            Console.WriteLine();
            double y = Utils.Input<double>("y");
            NM.SplitNumber(y, out int intPart, out int floatPart);
            intPart.Output("Целая часть");
            floatPart.Output("Дробная часть");

            //max
            Console.WriteLine("\nВведите не число, чтобы остановить ввод");
            List<double> z = new List<double>();
            while(double.TryParse(Utils.Input<string>($"число #{z.Count() + 1}"), out double input))
            {
                z.Add(input);
            }
            NM.Max(z.ToArray()).Output("Максимальное число");
        }
    }
}
