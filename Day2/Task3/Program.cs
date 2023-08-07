using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Program { 

    class Program
    { 

        static void Main(string[] args){
            Console.WriteLine("*****PALINDROME CHECKER");
            Console.WriteLine("Enter your word");
            var input = Console.ReadLine();
            bool ans = IsPalindrome(input);
            Console.WriteLine($"**ANSWER*** Your Word is {(ans ? "" : "not ")}palindrome");  
            
        }

        static bool IsPalindrome(string input)
        {
            var strippedInput = Regex.Replace(input, @"\W+", "").ToLower();
            var reversedInput = new string(strippedInput.ToCharArray().Reverse().ToArray());
            return strippedInput == reversedInput;
        }


    }


}