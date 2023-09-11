using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FencyArr_AtHome
{
    public class FencyArr
    {

    private int[] array;




        public FencyArr(int n)
        {
            array = new int[n];
            // לא חובה לאפס מערך בסישארפ אבל חשוב להראות את הדרך הזו
            for ( int i=0;i<array.Length;i++)
            {
                array[i] = 0;
            }

           


        }


        public int[] GetArray()
        {
            return array;
        }
        public void InitRandom(int from, int to)
        {
           Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(from, to);
            }
        }
        public bool IsTriple(int i)
        {
            if (i < 0 || i >= array.Length)
            {
                return false;  //מחזיר שקר אם האינדקס לא קיים במערך
            }
            // מחזיר אמת אם המספר הוא תלת ספרתי
            int valueAtIndex = array[i];
            return valueAtIndex >= 100 && valueAtIndex <= 999; 
        }

        public int SumTriple()
        {
            int sum = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.IsTriple(i))
                    sum += this.array[i];
            }
            return sum;
        }
        public int GreaterTriples(int n)
        {
            int count = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.IsTriple(i) && this.array[i] > n)
                    count++;
            }
            return count;
        }

    }
}
