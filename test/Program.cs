using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesGivenRange
{
    class Program
    {
        static List<int> GetPrimes(int start, int end)
        {
            List<int> PrimeList = new List<int>();

            for (int currentNum = start; currentNum <= end; currentNum++)
            {
                if (currentNum < 2)
                {
                    ;
                }

                bool IsPrime = true;
                double numSqrt = Math.Sqrt(currentNum);
                for (int diffence = 2; diffence <= numSqrt; diffence++)
                {
                    if (currentNum % diffence == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    PrimeList.Add(currentNum);
                }
            }
            return PrimeList;
        }

        static void Main(string[] args)
        {
            int startNumb = int.Parse(Console.ReadLine());
            int endNumb = int.Parse(Console.ReadLine());

            List<int> primes = GetPrimes(startNumb, endNumb);
            foreach (var item in primes)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}