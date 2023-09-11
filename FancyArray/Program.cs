using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FancyArray216
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FancyArr Fancy =  new FancyArr(10);
            FancyArr Fancy2 = new FancyArr(3);

            Fancy.InitRandom(1,200000);
            int[] arr = Fancy.getArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]},");
            }
            Console.WriteLine();
        }
    }
}
