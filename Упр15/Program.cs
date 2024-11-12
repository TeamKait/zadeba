using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utils.PrintAuthors();
            string Str = "Самый простой способ построить символьную строку. Самый легкий путь.";
            Str.Output("Str");
            string userStr = Utils.Input<string>("строку");
            (Str.Split(new string[] { userStr }, StringSplitOptions.None).Length - 1).Output("Количество входов строки в Str");
            (Str.IndexOf(userStr) + 1).Output("Первое вхождение");
            (Str.LastIndexOf(userStr) + 1).Output("Последнее вхождение");
        }
    }
}
