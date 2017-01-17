using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceAtag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"<a.*=(.+)>(.+)<\/a>";
            string replace = @"[URL href=$1]$2[/URL]";
            string text = null;
            while (input!="end")
            {                
                text = Regex.Replace(input,pattern,replace);
                Console.WriteLine(text);
                input = Console.ReadLine();
            }
            
        }
    }
}
