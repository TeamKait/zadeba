using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнили Лющенко Артём, Владислав Дерин");
            Algorithm();
        }
        static void Algorithm()
        {
            int[] numbers = new int[4];
            foreach (int i in numbers)
            {
                numbers[numbers.ToList().IndexOf(i)] = Int32.Parse(Console.ReadLine());
            }
            //Max and min numbers
            int min = Int32.MaxValue;
            int max = 0;
            foreach (int i in numbers)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine($"\nМинимальное число: {min}\n");
            Console.WriteLine($"Максимальное число: {max}\n");

            //sorting
            bool valid = false;
            while (!valid)
            {
                valid = true;
                for (int i = 0; i < numbers.Length; i++)
                {
                    try
                    {
                        if (numbers[i] > numbers[i + 1])
                        {
                            valid = false;
                            int buffer = numbers[i];
                            numbers[i] = numbers[i + 1];
                            numbers[i + 1] = buffer;
                        }
                    }
                    catch (Exception e) { }
                }
            }
            string result = "По возрастанию: ";
            foreach (int i in numbers)
            {
                result += i + (numbers.ToList().IndexOf(i) != numbers.Length - 1 ? ", " : "");
            }
            Console.Write(result);
            result = "\nПо убыванию: ";
            foreach (int i in numbers.Reverse())
            {
                result += i + (numbers.Reverse().ToList().IndexOf(i) != numbers.Length - 1 ? ", " : "");
            }
            result += "\n";
            Console.Write(result);
            Console.WriteLine("\nВвести числа повторно?\nY-да\nN-нет");
            if (Console.ReadLine().ToLower() == "y")
            {
                Algorithm();
            }
        }
    }
}
