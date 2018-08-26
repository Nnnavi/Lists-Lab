using System;
using System.Collections.Generic;

namespace _4_SplitByWordCasing
{
    class Program
    {
        static string WordType (string word)
        {
            var upperLetters = 0;
            var lowerLetters = 0;
            string WordType = mixedType;

            foreach (var letter in word)
            {
                if (char.IsUpper(letter)
                {
                    upperLetters++;
                }
                else if (char.IsLower(letter)
                {
                    lowerLetters++;
                }
                if (upperLetters==word.Length)
                {
                    return WordType = UpperCase;
                }
                if (lowerLetters==word.Length)
                {
                    return WordType = LowerCase;
                }
            }
            return WordType;
        }
        static void Main(string[] args)
        {
            var separators = new char[]
               {
                ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[',']',' '
               };
            var word = Console.ReadLine().Split(separators,
             StringSplitOptions.RemoveEmptyEntries);//.ToList();
            var lowerCaseList = new List<string>();
            var upperCaseList = new List<string>();
            var mixedCaseList = new List<string>();

            foreach (var w in word)
            {
                if (WordType(word[w])="LowerCase")
                {
                    lowerCaseList.Add(w);
                }
                else if (WordType(word[]) = "UpperCase")
                {
                    upperCaseList.Add(w);
                }
                else mixedCaseList.Add(w);
                Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseList));
                Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseList));
                Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseList));
            }
        }
        }
}
