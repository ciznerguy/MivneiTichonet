using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3AtHome
{
    internal class Program
    {
      
        public static int Count1Or7(int[] arr)
        {
            int count1=0,count7=0;  
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    count1++;
                }
                else
                {
                    count7++;
                }
            }
            if (count1 > count7)
            {
                return 1;
            }
            return 7;
        }
        
        public static int countNegSeq (int[] arr)
        {
            int count = 0;
            int i = 0;

            while (arr[i]>=0 && i < arr.Length)
            { 
               i++;
            }
            while (arr[i]<0 && i < arr.Length)
            {
                count++;
                i++;
            }
            return count;
        }
        static void Main(string[] args)
            {
            int[] arrOnMain1 = { 1, 6, -7, 9, 10, 11, 12, 13 };
            int[] arrOnMain2 = { 1, 6, -7, -9, -10, 11, 12, 13 };

            Console.WriteLine( countNegSeq(arrOnMain1) );

            Console.WriteLine(countNegSeq(arrOnMain2));
        }
    }
}
