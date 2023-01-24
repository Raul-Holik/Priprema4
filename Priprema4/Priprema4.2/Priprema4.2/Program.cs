using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz1 = { 1, 2, 3, 4, 5, 6};
            int[] niz2 = { 1, 8, 9, 4, 5, 9};
            int x42, count = 0;
            if (niz1.Length < niz2.Length)
            {
                x42 = niz1.Length;
            }
            else
            {
                x42 = niz2.Length;
            }
            for (int i = 0; i < x42; i++)
            {
                if (niz1[i] == niz2[i])
                {
                    count++;
                }
            }
            Console.WriteLine("Broj zajedničkih članova je: "+ count);

            Console.ReadKey();
        }
    }
}
