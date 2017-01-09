using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', '.', ',', '?', '!' };
            string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            foreach (var word in words)
            {
                bool isPalindrome = true;
                for (int i = 0; i < word.Length/2; i++)
                {
                    if (!word[i].Equals(word[word.Length-1-i]))
                    {
                        isPalindrome = false;
                    }
                }
                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(n=> n)));
        }
    }
}
