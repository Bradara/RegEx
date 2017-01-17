using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine().TrimStart('0');
            string num2 = Console.ReadLine().TrimStart('0');
            if (num1=="0"||num2=="0")
            {
                Console.WriteLine("0");
            }
            else
            {
                string multiplied = MultiplyBigNumber(num1, num2);
                Console.WriteLine(multiplied);
            }
        }

        private static string MultiplyBigNumber(string num1, string num2)
        {
            string result = string.Empty;
            for (int i = 0; i < num1.Length; i++)
            {                
                int firstNum = int.Parse(num1[num1.Length - 1 - i].ToString());
                string multiply = MultiPlyOne(firstNum, num2)+new string('0',i);
                result = SumBigNumber(result, multiply);
            }
            return result;
        }

        private static string MultiPlyOne(int firstNum, string num2)
        {
            string result = string.Empty;
            int inMind = 0;
            for (int i = 0; i < num2.Length; i++)
            {
                int sum = inMind + firstNum * int.Parse(num2[num2.Length - 1 - i].ToString());
                inMind = sum / 10;
                sum = sum % 10;
                result = sum + result;
            }
            if (inMind>0)
            {
                result = inMind + result;
            }
            return result;
        }

        private static string SumBigNumber(string num1, string num2)
        {
            StringBuilder result = new StringBuilder();
            int oneInMind = 0;
            int dif = Math.Abs(num1.Length - num2.Length);
            if (num1.Length > num2.Length)
            {
                num2 = string.Concat(new string('0', dif), num2);
            }
            else if (num1.Length < num2.Length)
            {
                num1 = string.Concat(new string('0', dif), num1);
            }
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int sum = int.Parse(num1[i].ToString()) + int.Parse(num2[i].ToString()) + oneInMind;
                oneInMind = sum / 10;
                sum = sum % 10;
                result = result.Insert(0, sum);
            }
            if (oneInMind > 0)
            {
                result = result.Insert(0, oneInMind);
            }
            return result.ToString();
        }
    }
}
