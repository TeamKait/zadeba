using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Utils
{
    //print authors
    public static void PrintAuthors()
    {
        Console.WriteLine("\t\t\t\t\t~~------------------------------------~~\n\t\t\t\t\tВыполнили Лющенко Артём, Владислав Дерин\n\t\t\t\t\t                 ИСП211\n\t\t\t\t\t~~------------------------------------~~\n");
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
    public static void Output<T>(this T variable, string name)
    {
        Console.WriteLine($"\n{name} = {variable}");
    }
}

