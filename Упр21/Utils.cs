﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Utils
{
    private static Stopwatch executionTime = new Stopwatch();
    public static Random random = new Random();


    /// <summary>
    /// Вывести авторов + время выполнение программы
    /// </summary>
    public static void PrintAuthors()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("----------------------------------------\n");
        Console.WriteLine("Выполнили Лющенко Артём, Владислав Дерин\n");
        Console.WriteLine("                ИСП211\n");
        Console.WriteLine("----------------------------------------");
        Console.ResetColor();

        executionTime.Start();
        //on exit
        AppDomain.CurrentDomain.ProcessExit += delegate (object sender, EventArgs e)
        {
            executionTime.Stop();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine($"Время: {Math.Round(executionTime.Elapsed.TotalMilliseconds)}мс | {Math.Round(executionTime.Elapsed.TotalSeconds, 2)}с");
        };
    }


    /// <summary>
    /// Быстрый ввод переменной + парсинг в переданный тип
    /// </summary>
    /// <typeparam name="T">Тип переменной</typeparam>
    /// <param name="name">Имя переменной (опционально)</param>
    /// <returns>Ввод с консоли</returns>
    public static T Input<T>(string name)
    {
        Console.WriteLine($"Введите {name}:");
        return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
    }
    public static void Input<T>(this T variable, string name)
    {
        Console.WriteLine($"Введите {name}:");
        variable = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
    }


    /// <summary>
    /// Быстрый вывод переменной
    /// </summary>
    /// <typeparam name="T">Тип переменной (опционально, можно вызвать с переменной)</typeparam>
    /// <param name="variable">Переменная</param>
    /// <param name="name">Имя (опционально)</param>
    public static void Output<T>(this T variable, string name = "")
    {
        Console.WriteLine($"{name.Replace(':', '\0')} = {variable}");
    }
    public static void Output<T>(this T[] variable, string name = "")
    {
        Console.WriteLine($"{name.Replace(':', '\0')} = {String.Join(", ", variable)}");
    }
    public static void Output(this Array array, bool printIndices = false)
    {
        int maxLength = 0;
        array.Map(element => { maxLength = Math.Max(maxLength, element.ToString().Length); });
        if(array.Rank == 2)
        {
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    if (printIndices)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($"[{y},{x}]:");
                        Console.ResetColor();
                        Console.Write(array.GetValue(y, x));
                    }
                    else
                    {
                        Console.Write(array.GetValue(y, x));
                    }
                    for (int i = 0; i <= maxLength - array.GetValue(y, x).ToString().Length + 1; i++) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            for (int x = 0; x < array.GetLength(0); x++)
            {
                if (printIndices)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write($"[{x}]:");
                    Console.ResetColor();
                    Console.Write(array.GetValue(x));
                }
                else
                {
                    Console.Write(array.GetValue(x));
                }
                for (int i = 0; i <= maxLength - array.GetValue(x).ToString().Length + 1; i++) Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    

    /// <summary>
    /// Вывод красивой ошибки
    /// </summary>
    /// <param name="errorMessage">Содержание ошибки</param>
    public static void PrintError(string errorMessage)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"ошибка: {errorMessage}".ToUpper());
        Console.ResetColor();
    }
    

    /// <summary>
    /// Выполнение действие над массивом любой размерности
    /// </summary>
    /// <param name="array">Массив (можно вызвать из него)</param>
    /// <param name="action">Само действие</param>
    /// <param name="dimension"></param>
    /// <param name="indices"></param>
    public static void Map(this Array array, Func<object, object> action, int dimension = 0, int[] indices = null)
    {
        if(indices == null) indices = new int[array.Rank];

        for (int i = 0; i < array.GetLength(dimension); i++)
        {
            indices[dimension] = i;

            if (dimension == array.Rank - 1)
            {
                var newValue = action(array.GetValue(indices));
                array.SetValue(newValue, indices);
            }
            else
            {
                Map(array, action, dimension + 1, indices);
            }
        }
    }
    public static void Map(this Array array, Action<object> action, int dimension = 0, int[] indices = null)
    {
        if (indices == null) indices = new int[array.Rank];

        for (int i = 0; i < array.GetLength(dimension); i++)
        {
            indices[dimension] = i;

            if (dimension == array.Rank - 1)
            {
                action(array.GetValue(indices));
            }
            else
            {
                Map(array, action, dimension + 1, indices);
            }
        }
    }
}
public struct Constants
{
    /// <summary>
    /// abcdefghijklmnopqrstuvwxyz
    /// </summary>
    public static string lowerAlphabet => "abcdefghijklmnopqrstuvwxyz";
    /// <summary>
    /// ABCDEFGHIJKLMNOPQRSTUVWXYZ
    /// </summary>
    public static string upperAlphabet => lowerAlphabet.ToUpper();
    /// <summary>
    /// 0123456789
    /// </summary>
    public static string numbers => "0123456789";
    /// <summary>
    /// abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ
    /// </summary>
    public static string fullAlphabet => lowerAlphabet + upperAlphabet;
    /// <summary>
    /// 0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ
    /// </summary>
    public static string alpabetNumbers => numbers + fullAlphabet;
}