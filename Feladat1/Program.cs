using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] matrix = new int[15];
            int generaltszam;

            for (int i = 0; i < matrix.Length; i++)
            {
                generaltszam=rnd.Next(0,101);
                matrix[i]=generaltszam;
               



            }

            foreach (int item in matrix)
            {
                Console.Write($"{item},");
            }
            Console.ReadKey();
        }
    }
}
