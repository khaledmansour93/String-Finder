using System;

namespace StringFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Text: ");
            String text = Console.ReadLine();
            Char firstLetter, lastLetter = ' ';
            do
            {
                Console.Write("Please Enter The Word's First Letter: ");
            } while (!char.TryParse(Console.ReadLine(), out firstLetter));
            do
            {
                Console.Write("Please Enter The Word's Last Letter: ");
            } while (!char.TryParse(Console.ReadLine(), out lastLetter));
            FindMatchedWord(text, firstLetter, lastLetter);
        }

        static void FindMatchedWord(String text, Char firstLetter, Char lastLetter)
        {
            bool flag = true;
            String[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].ToLower().StartsWith(firstLetter.ToString().ToLower()) && !words[i].ToLower().EndsWith(lastLetter.ToString().ToLower()) && words.Length > 1 && flag)
                {
                    flag = false;
                }
                else if (words[i].ToLower().StartsWith(firstLetter.ToString().ToLower()) && words[i].ToLower().EndsWith(lastLetter.ToString().ToLower()))
                    Console.WriteLine($"{words[i]}");
                else
                    Console.WriteLine("Word does not exist");
            }
        }
    }
}
