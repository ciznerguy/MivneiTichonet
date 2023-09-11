using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FencyArr214
{
    public class FencyArr
    {
        private int[] arr;
        private string name;

        public FencyArr(int n, string name) 
        { 
            this.arr = new int[n]; 
            this.name = name;
            for (int i = 0; i < this.arr.Length; i++)
            {
                this.arr[i] = 0;
            }
        }

        public int[] GetArr() 
        {
            return this.arr;
        }

        public void InitRandom(int from, int to)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i ++) 
            {
                this.arr[i] = rnd.Next(from,to);
            }
        }

        public bool IsTriple(int n)
        {
            if (this.arr[n] > 99 && this.arr[n] < 1000 && n < arr.Length)
            {
                return true;
            }
            return false;
        }
    }
    
}
