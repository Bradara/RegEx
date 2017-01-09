using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string search = Console.ReadLine().ToLower();
            int count = 0;
            int index = text.IndexOf(search);
            while (index!=-1)
            {
                count++;
                index = text.IndexOf(search, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
