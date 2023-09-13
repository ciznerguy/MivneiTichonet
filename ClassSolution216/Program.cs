using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSolution216
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = { -1,-1,1,7,-7};
            int[] arrTwo = { 7,7,-7,-1,-1,5};
            int[] arrThree = { 58,64920,111,234,7};
            int[] arrFour = { 58, -64920, 111, 234, 7 };

            int NegativeCount = NegativeSeqWithWhile(arrThree);
            int NegativeCountTwo = NegativeSeqWithFor(arrThree);
            Console.WriteLine(NegativeCount);
            Console.WriteLine(NegativeCountTwo);
        }

        public static int SevenOrOne(int[] arr)
        { 
            int countSeven = 0, countOne = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    countOne++;
                }
                else
                { 
                    countSeven++;
                }
            }
            if (countOne > countSeven)
            {
                return 1;
            }
            return 7;
        }

        public static int NegativeSeqWithWhile(int[] arr)
        {
            int i = 0;
            int countNegative = 0;
            while (i < arr.Length && arr[i] >= 0 )
            {
                i++;
            }
            while (i < arr.Length && arr[i] < 0)
            { 
                countNegative++;
                i++;
            }
            return countNegative;
        }
        public static int NegativeSeqWithFor(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > 0 && count > 0)
                {
                    return count;
                }
                if (arr[i] < 0)
                {
                    count++;
                } 

            }
            return count;
        }

    }
}
