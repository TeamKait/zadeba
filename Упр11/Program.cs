using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр11
{
    internal class Program
    {
        static int Max(int[] nums)
        {
            int max = int.MinValue;
            foreach (int i in nums)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            return max;
        }
        static int Min(int[] nums)
        {
            int min = int.MaxValue;
            foreach (int i in nums)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            return min;
        }
        static void Main(string[] args)
        {
            Utils.PrintAuthors();

            int[] MAS = { 3, 10, 12, 1, 2, -4, 6, 12, -1, 2, -2, 12 };
            int max = Max(MAS);
            int min = Min(MAS);
            Console.WriteLine("Max: " + max + " Min: " + min + "\n");

            int[] even = Array.Empty<int>();
            int[] odd = Array.Empty<int>();

            //<value, repeat>
            Dictionary<int, int> repeats = new Dictionary<int, int>();

            foreach(int item in MAS)
            {
                if (repeats.ContainsKey(item)) repeats[item]++;
                else repeats.Add(item, 0);

                if(item % 2 == 0) even = even.Append(item).ToArray();
                else odd = odd.Append(item).ToArray();
            }
            even.Output("Чётные");
            odd.Output("Нечётные");
            Console.Write("\n");

            foreach(int key in repeats.Keys)
            {
                if (repeats[key] != 0)
                {
                    Console.WriteLine($"Количество повторов {key} = {repeats[key]+1}");
                }
            }
        }
    }
}
