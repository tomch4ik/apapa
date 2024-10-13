using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apapa
{
    internal class Work4
    {
        static void Main()
        {     
            string text = @"To be, or not to be, that is the question,
Whether 'tis nobler in the mind to suffer
The slings and arrows of outrageous fortune,
Or to take arms against a sea of troubles,
And by opposing end them? To die: to sleep;
No more; and by a sleep to say we end
The heart-ache and the thousand natural shocks
That flesh is heir to, 'tis a consummation
Devoutly to be wish'd. To die, to sleep.";

            string BanWord = "die";

            string censoredText = ReplaceWord(text, BanWord, out int count);

            // Вывод результата
            Console.WriteLine("Result:");
            Console.WriteLine(censoredText);
            Console.WriteLine($"\nСтатистика: {count} замены слова '{BanWord}'.");
        }

        static string ReplaceWord(string text, string BanWord, out int count)
        {
            count = 0;         
            string replacement = new string('*', BanWord.Length);
            string[] words = text.Split(' ', '\n', '\r', ',', '.', ';', ':', '!', '?', '-');       
            foreach (string word in words)
            {
                if (word.Contains(BanWord))
                {
                    count++;
                }
            }     
            string censoredText = text.Replace(BanWord, replacement);
            return censoredText;
        }
    }
}
