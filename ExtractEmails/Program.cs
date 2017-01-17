using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().TrimEnd('.').Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"^(?=[a-z0-9])([a-z0-9]+[\w\.-]+[a-z0-9])@([a-z0-9]+[\w\.-][a-z]+\.[\w\.]+[a-z])$";
            List<string> mails = new List<string>();
            foreach (var item in input)
            {
                if (Regex.IsMatch(item, pattern))
                {
                    mails.Add(item);
                }
            }
            Console.WriteLine(string.Join("\n", mails));
        }
    }
}
