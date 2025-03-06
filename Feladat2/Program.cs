using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            
            int generaltszam;
            Console.Write("Add meg a tömb méretét: ");
            int N = int.Parse(Console.ReadLine());
            int[] matrix = new int[N];

            Console.WriteLine();
            for (int i = 0; i < matrix.Length; i++)
            {
                generaltszam = rnd.Next(50, 150);

                matrix[i] = generaltszam;

            }
            int max=0;
            int min=151;

            Console.WriteLine("A tömb elemei:");
            foreach (int item in matrix)
            {

                Console.Write($"{item} ");
                if(item > max)
                {
                    max=item;
                }
                if(item < min)
                {
                    min=item;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"A legnagyobb szám: {max}");
            Console.WriteLine($"A legkisebb szám: {min}");
            Array.Sort(matrix);
            Array.Reverse(matrix);
            Console.WriteLine();
            Console.WriteLine("A tömb csökkenő sorrendben: ");
            foreach (int item in matrix)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
