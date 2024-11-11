using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр16
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Выполнили: Дерин, Лющенко. ИСП211");
            Console.WriteLine("Введите выражение (например, 12+56-10=):");
            string input = Console.ReadLine();

            if (input.EndsWith("="))
            {
                input = input.TrimEnd('=');
            }

            try
            {
                int result = EvaluateExpression(input);
                Console.WriteLine($"{input} = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при вычислении выражения: " + ex.Message);
            }
        }

        static int EvaluateExpression(string expression)
        {
            List<int> numbers = new List<int>();
            List<char> operators = new List<char>();
            string currentNumber = "";

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (char.IsDigit(ch))
                {
                    currentNumber += ch;
                }
                else if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
                {
                    numbers.Add(int.Parse(currentNumber));
                    operators.Add(ch);
                    currentNumber = "";
                }
                else
                {
                    throw new ArgumentException("Недопустимый символ в выражении.");
                }
            }

            if (!string.IsNullOrEmpty(currentNumber))
            {
                numbers.Add(int.Parse(currentNumber));
            }

            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '*' || operators[i] == '/')
                {
                    int left = numbers[i];
                    int right = numbers[i + 1];
                    int result = operators[i] == '*' ? left * right : left / right;

                    numbers[i] = result;
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--;
                }
            }

            int finalResult = numbers[0];
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '+')
                {
                    finalResult += numbers[i + 1];
                }
                else if (operators[i] == '-')
                {
                    finalResult -= numbers[i + 1];
                }
            }

            return finalResult;
        }
    }
}
