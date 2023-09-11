using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Class3Solution214
{
    internal class Program
    {
        
       public static int SevenOrOne(int[] arr)
        {
            int counter7 = 0,counter1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    counter1++;
                }
                else
                {
                    counter7++;
                }
            }
            if (counter1 > counter7)
            {
                return 1;
            }
            return 7;


        } 
        
       

        public static int negSeqFor(int[] arr)
        {
            int count = 0;
            bool counted = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 && counted==false)
                {
                    count++;
                    counted = true;
                }
                else if (counted==true)
                {
                    counted=true;
                    
                }
               
            }
            return count;

        }
        public static int FirstNegativeSeq(int[] arr)
        {
            int count = 0;
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                    flag = true;
                }
                else if (arr[i] > 0 && flag)
                {
                    return count;
                }
            }
            return count;

        }


        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 1, 7, 7, 7, 7 };
            int result = FirstNegativeSeq(arr);
            Console.WriteLine(result);
        }
    }
}
