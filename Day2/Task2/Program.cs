using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordFrequencyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            var input = Console.ReadLine();
            var frequency = WordFrequency(input);
            Console.WriteLine("Word frequency:");
            foreach (var item in frequency)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }

        public static Dictionary<string, int> WordFrequency(string input)
        {
            var wordFrequency = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            var words = Regex.Split(input, @"\W+");
            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    if (wordFrequency.ContainsKey(word))
                    {
                        wordFrequency[word]++;
                    }
                    else
                    {
                        wordFrequency[word] = 1;
                    }
                }
            }
            return wordFrequency;
        }
    }
}
