using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterChangeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> alphabet = new Dictionary<char, int>();
            for (char i = 'a'; i <= 'z';i=(char)(i+1))
            {
                alphabet.Add(i, i - 96);
            }
            for (char i = 'A'; i <= 'Z'; i = (char)(i + 1))
            {
                alphabet.Add(i, i - 64);
            }
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' },StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0m;
            foreach (var item in input)
            {
                string numS =string.Join("", item.Skip(1).Take(item.Length - 2).ToArray());
                decimal num = decimal.Parse(numS);
                char first = item[0];
                char last = item[item.Length - 1];
                if (first>=65&&first<=90)
                {
                    num = num / alphabet[first];          
                    
                }
                else if (first >= 97 && first <= 122)
                {
                    num= num * alphabet[first];
                }
                if (last >= 65 && last <= 90)
                {
                    num = num - alphabet[last];
                }
                else if (last >= 97 && last <= 122)
                {
                    num = num + alphabet[last];
                }
                result += num;
            }
            Console.WriteLine("{0:f2}",result);
        }
    }
}
