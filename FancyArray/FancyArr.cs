using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyArray216
{

    public class FancyArr
    {
        private int[] FancyArray;

        public FancyArr(int n)
        {
            this.FancyArray = new int[n];
            for (int i = 0; i < FancyArray.Length; i++)
            {
                this.FancyArray[i] = 0;
            }
        }
        public void InitRandom(int from, int to)
        { 
            Random random = new Random();
            for (int i = 0; i < this.FancyArray.Length; i++)
            {
                this.FancyArray[i] = random.Next(from, to);
            }
        }
        public bool IsTriple(int index)
        {
            if (index >= FancyArray.Length || index < 0)
            {
                return false;   
            }
            if (FancyArray[index] >= 100 && FancyArray[index] <= 999)
            {
                return true;
            }

            return false;

        }
        public int SumTriple()
        {
            int sum = 0;
            for (int i = 0; i < this.FancyArray.Length; i++)
            {
                if (this.IsTriple(i))
                {
                    sum += this.FancyArray[i];
                }
            }
            return sum;
        }

        public int[] getArray()
        {
            return this.FancyArray;
        }

        
    }
}
