using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySongClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song s1,s2,s3,temp;
            Song[] songArr = new Song[3];
            songArr[0] = new Song("hi",6,98);
            Console.WriteLine("song in array " + songArr[0]);
            // קלט שיר מספר 1
            Console.WriteLine( "enter song name numer 1");
            string name = Console.ReadLine();
            Console.WriteLine("enter song genre numer 1");
            int genre = int.Parse(Console.ReadLine());
            Console.WriteLine("enter song length numer 1");
            int length = int.Parse(Console.ReadLine());
            s1=new Song(name, genre,length);
            Console.WriteLine( s1);


            // קלט שיר מספר 2
            Console.WriteLine("enter song name numer 1");
            name = Console.ReadLine();
            Console.WriteLine("enter song genre numer 1");
             genre = int.Parse(Console.ReadLine());
            Console.WriteLine("enter song length numer 1");
             length = int.Parse(Console.ReadLine());
            s2 = new Song(name, genre, length);
            Console.WriteLine(s2);

            if (s1.GetLength()>s2.GetLength())
            {
                temp = s1;
                s1 = s2;
                s2 = temp;
            }

            Console.WriteLine( s1);

        }
    }
}
