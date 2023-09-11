using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FencyArr214
{
    internal class Program
    {
        static void Main(string[] args)
        {
           FencyArr Fency1 = new FencyArr(100, "noa");
           FencyArr Fency2 = new FencyArr(1000, "dabush");
            Fency2.InitRandom(1, 1001);
            int[] arrOnMain = Fency2.GetArr();
            Console.WriteLine(arrOnMain[0]);
        }
    }
}
