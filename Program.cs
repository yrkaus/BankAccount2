using System;
using System.Text;
using System.Linq;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            string sentence = "Найти сумму четных чисел и их количество в диапазоне";
            Console.WriteLine(sentence);
            int wordLength = 0;
            wordLength = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Enter word length: ");
                try
                {
                    wordLength = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number");
                }
            }                               
            
            string[] words = sentence.Split(" ");

            for (int i = 0; i <= words.Length - 1; i++)
            {
                if (words[i].Length == wordLength && wordLength >=3)
                {
                    words[i] = words[i].Substring(0, words[i].Length - 3) + "$$$";
                }
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
