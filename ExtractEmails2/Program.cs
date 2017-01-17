using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '/', '\\', '(', ')' },
                                               StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"(?:^| )([a-z][a-z0-9\-\._]+@[a-z0-9\-]+(\.[a-z0-9\-]+){1,})";
            List<string> passwords = new List<string>();
            foreach (var item in input)
            {
                if (Regex.IsMatch(item, pattern))
                {
                    passwords.Add(item);
                }
            }
            int index = 0, greaterSum = 0;           
            for (int i = 1; i < passwords.Count; i++)
            {
               
                    int sum = passwords[i - 1].Length + passwords[i].Length;
                    if (sum>greaterSum)
                    {
                        index = i;
                        greaterSum = sum;
                    }
                
            }
            Console.WriteLine(passwords[index-1]);
            Console.WriteLine(passwords[index]);
        }
    }
}
