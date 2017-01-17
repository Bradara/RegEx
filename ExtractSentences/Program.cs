using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = string.Concat(@"(?=[A-Z0-9])[^\!\?\.]*[^A-Za-z0-9]", word, @"[^A-Za-z0-9][^\!\?\.]*(?=\!|\.|\?)");
            // @"(?=[A-Z0-9])[^\!\?\.]*"+" " word +" " + @"[^\!\?\.]*(?=\!|\.|\?)";
            foreach (Match item in Regex.Matches(input, pattern))
            {
                Console.WriteLine(item);
            }
        }
    }
}
