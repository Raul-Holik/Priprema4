using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz1 = new int[10];
            int[] niz2 = new int[10];
            int br, n1 = 0, n2 = 0;
            do
            {
                Console.WriteLine("Upišite broj:");
                br = Convert.ToInt32(Console.ReadLine());
                if (br % 2 != 0)
                    niz1[n1++] = br;
                else
                    niz2[n2++] = br;
            } while (br != 0 && n1 < 10 && n2 < 10);
            Console.WriteLine();
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine(niz1[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine(niz2[i]);
            }
            Console.ReadKey();
        }
    }
}
