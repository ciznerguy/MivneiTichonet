using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
       // פעולה רקורסיבית המקבלת מספר ומחזירה את אורכו
        static int CountDigits(int number)
        {
           
            if (number < 10)
                return 1;  // אם המספר קטן מ-10 אורך המספר 1

            return 1 + CountDigits(number / 10);
        }
        static int CountEvenDigits(int number)
        {
            if (number < 10 && number % 2 == 0)
            {
                return 1;
            }
            if (number < 10 && number % 2 != 0)
            {
                return 0;
            }

        

            int lastDigit = number % 10;
            if (lastDigit % 2 == 0)
                return 1 + CountEvenDigits(number / 10);
            else
                return CountEvenDigits(number / 10);
        }

        // פעולה המחשבת סכום ספרות של מספר
        static int SumDigits(int number)
        {
            if (number == 0)
                return 0;

            int lastDigit = number % 10;

            return lastDigit + SumDigits(number / 10);
        }

        static int Fibonacci(int k)
        {
            if (k == 0) return 0;
            if (k == 1) return 1;

            return Fibonacci(k - 1) + Fibonacci(k - 2);
        }
        static void Main(string[] args)
        {
            int num = 44334;
            int countDigits = CountDigits(num);
            Console.WriteLine($"number of  digits {countDigits}"  );
            int countEvenDigits = CountEvenDigits(num);
            Console.WriteLine($"number of even  digits {countEvenDigits}");
            int sumDigits = SumDigits(num);
            Console.WriteLine($"sum of   digits {sumDigits}");
            int k = 4;
            int fResult = Fibonacci(k);
            Console.WriteLine($"the fibonaci in index {k} is {fResult}");
        }
    }
}
