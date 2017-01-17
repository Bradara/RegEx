using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?=[A-Za-z])\w{2,24}";
            List<string> usernames = new List<string>();
            foreach (Match item in Regex.Matches(input, pattern))
            {
                usernames.Add(item.ToString());
            }
            int index = 0, greaterSum = 0;
            for (int i = 1; i < usernames.Count; i++)
            {               
                    int sum = usernames[i - 1].Length + usernames[i].Length;
                    if (sum>greaterSum)
                    {
                        greaterSum = sum;
                        index = i;
                    }                
            }
            Console.WriteLine(usernames[index-1]);
            Console.WriteLine(usernames[index]);
            Regex rgx = new Regex();
        }
    }
}
