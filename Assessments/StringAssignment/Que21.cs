using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    public class Que21
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string replacedSentence = ReplaceVowels(sentence);
            Console.WriteLine("Replaced Sentence: " + replacedSentence);
        }

        static string ReplaceVowels(string input)
        {
            
            string vowels = "aeiouAEIOU";
            string replacements = "bfjpvBFJPV";

            char[] characters = input.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                int index = vowels.IndexOf(characters[i]);
                
                if (index != -1)
                {
                    characters[i] = replacements[index];
                }
            }

            return new string(characters);
        }
    }
}
