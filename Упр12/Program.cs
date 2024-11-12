using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utils.PrintAuthors();
            int a = Utils.Input<int>("A");
            int b = Utils.Input<int>("B");
            int amount = Utils.Input<int>("Количество чисел");

            int[] randomNumbers = Array.Empty<int>();
            Random rand = new Random();
            // num , amount
            Dictionary<int, int> statistics = new Dictionary<int, int> { { 3, 0 }, { 5, 0 }, {8, 0}, { 11, 0 } };
            for(int i = 0; i < amount; i++)
            {
                int curr = rand.Next(a, b + 1);
                randomNumbers = randomNumbers.Append(curr).ToArray();
                foreach(int key in statistics.Keys.ToList())
                {
                    if(curr % key == 0 && curr != 0) statistics[key]++;
                }
            }
            randomNumbers.Output("\nСлучайные числа");
            Console.WriteLine("\n");
            foreach(int key in statistics.Keys)
            {
                Console.WriteLine($"Количество чисел кратные {key} – {statistics[key]}");
            }
            randomNumbers.Average().Output("Среднее");
        }
    }
}
