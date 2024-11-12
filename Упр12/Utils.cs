using System;
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
        Console.WriteLine($"\nВведите {name}:");
        return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
    }
    public static void Input<T>(this T variable, string name)
    {
        Console.WriteLine($"\nВведите {name}:");
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
    //print fancy error
    public static void PrintError(string errorMessage)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"ошибка: {errorMessage}".ToUpper());
        Console.ResetColor();
    }
}

