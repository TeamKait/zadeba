using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упр21
{
    class Word
    {
        public string content { get; set; }
        public Word(string text)
        {
            content = text;
        }

        public override string ToString() 
        {
            return content;
        }
    }
    class Book
    {
        public Word[] words;
        public Book(Word[] initWords = null)
        {
            if(initWords == null)
            {
                words = new Word[Utils.Input<int>("длину массива")];
                words.Map(element => new Word(Constants.fullAlphabet[Utils.random.Next(Constants.fullAlphabet.Length)].ToString()));
            }
            else
            {
                words = initWords;
            }
        }
        public Word this[int index]
        {
            get {
                try
                {
                    return words[index];
                }
                catch(IndexOutOfRangeException _)
                {
                    Utils.PrintError("Индекс вне пределов массива");
                }
                return null;
            }
            set => words[index] = value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Utils.PrintAuthors();
            Book bible = new Book();
            Console.WriteLine("\nИзначальный массив:");
            bible.words.Output(true);
            bible[Utils.Input<int>("индекс элемента")].Output("Элемент");

            Book koran = new Book(new[]
            {
                new Word("начало"), new Word("середина"), new Word("конец")
            });
            Console.WriteLine("\nkoran:");
            koran.words.Output(true);
        }
    }
}
