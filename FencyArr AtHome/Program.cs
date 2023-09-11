using FencyArr_AtHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
   
namespace FencyArrAtHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FencyArr arr1 = new FencyArr(100);
            FencyArr arr2 = new FencyArr(100);
            arr1.InitRandom(0, 2001);
            Thread.Sleep(2000);
            arr2.InitRandom(0, 2001);
            int sum1 = arr1.SumTriple();
            int sum2 = arr2.SumTriple();
            int num1 = arr1.GreaterTriples(99);
            int num2 = arr2.GreaterTriples(99);
            double num1d = (double)num1;
            double num2d = (double)num2;
            double averege1 = sum1 / num1d;
            double averege2 = sum2 / num2d;
            Console.WriteLine($"{averege1}, {averege2}" );
            Console.WriteLine($"Maximum is {Math.Max(averege1, averege2)}");


        }
    }
}
