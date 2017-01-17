using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string word1 = words[0];
            string word2 = words[1];
            int min = Math.Min(word1.Length, word2.Length);
            Dictionary<char, char> chars = new Dictionary<char, char>();
            bool isMagic = CheckMagic(word1, word2, min, chars, true);
            if (isMagic)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        private static bool CheckMagic(string word1, string word2, int min, Dictionary<char, char> chars, bool isMagic)
        {
            for (int i = 0; i < min; i++)
            {
                if (chars.ContainsKey(word1[i]))
                {
                    if (chars[word1[i]] == word2[i])
                    {
                        continue;
                    }
                    else
                    {
                        isMagic = false;
                
                    }
                }
                else if (chars.ContainsValue(word2[i]))
                {
                    isMagic = false;
                }
                else
                {
                    chars[word1[i]] = word2[i];
                }
            }
            for (int i = min; i < word1.Length; i++)
            {
                if (chars.ContainsKey(word1[i]))
                {
                    continue;
                }
                else
                {
                    isMagic = false;    
                }
            }
            for (int i = min; i < word2.Length; i++)
            {
                if (chars.ContainsValue(word2[i]))
                {
                    continue;
                }
                else
                {
                    isMagic = false;                   
                }
            }
            return isMagic;
        }
    }
}
