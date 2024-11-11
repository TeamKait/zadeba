﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Utils
{
    public static Stopwatch executionTime = new Stopwatch();
    //print authors
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
    //quickly input a variable
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
    //quickly output a variable
    public static void Output<T>(this T variable, string name = "")
    {
        Console.WriteLine($"{name.Replace(':', '\0')} = {variable}");
    }
    public static void Output<T>(this T[] variable, string name = "")
    {
        Console.WriteLine($"{name.Replace(':', '\0')} = {String.Join(", ", variable)}");
    }
    public static void OutPut(this Array array, bool printIndices = false)
    {
        int maxLength = 0;
        array.Map(element => { maxLength = Math.Max(maxLength, element.ToString().Length); });
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
    //print fancy error
    public static void PrintError(string errorMessage)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"ошибка: {errorMessage}".ToUpper());
        Console.ResetColor();
    }
    //foreach fundamental element in multidimensional array
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
