using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1011KissAdam
{
    internal class Program
    {
        static void tomb1()
        {
            int min = 1;
            int max = 100;
            Random szam = new Random();
            int[] tomb = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tomb[i] = szam.Next(min, max + 1);
            }
            Console.WriteLine("A tömb elemei: " + string.Join(", ", tomb));
        }

        static void kisnagy()
        {

            int min = 1;
            int max = 100;
            Random szam = new Random();
            int[] tomb = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tomb[i] = szam.Next(min, max + 1);
            }

            int legkisebb = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] < legkisebb) { legkisebb = tomb[i]; }
            }
            Console.WriteLine("A legkisebb elem: " + legkisebb);
            int legnagyobb = tomb[0];
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > legnagyobb)
                { legnagyobb = tomb[i]; }
            }
            Console.WriteLine("A legnagyobb elem: " + legnagyobb);
        }
        static void Main(string[] args)
        {
            tomb1();
            kisnagy();

        }
    }
}
