using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр19
{
    internal class Program
    {
        public static int Equation(int x)
        {
            return 2 * (x - 4) / (x + 5);
        }
        public static double Equation(double x)
        {
            return 2 * (x - 4) / (x + 5);
        }
        static void Main(string[] args)
        {
            Utils.PrintAuthors();
            string input = Utils.Input<string>("число");
            if(double.TryParse(input, out double result))
            {
                if(result == (int)result)
                {
                    Equation((int)result).Output("результат");
                }
                else
                {
                    Equation(result).Output("результат");
                }
            }
            else
            {
                Utils.PrintError("Не введено число");
            }
        }
    }
}
