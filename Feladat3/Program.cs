using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az n értékét: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            Random rnd = new Random();
            int generaltszam;
            int sorosszeg = 0;
            double db = n * n;
            int osszegszam=0;
            Console.WriteLine("Kétdimenziós tömb:");
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    generaltszam = rnd.Next(-20, 20);
                    matrix[i,j] = generaltszam;
                    //Console.Write(matrix[i,j]);
                   Console.Write($"{matrix[i,j],5}");
                    sorosszeg += matrix[i,j];
                }
                Console.Write($"| Sor összege: {sorosszeg}");
                osszegszam += sorosszeg;
                sorosszeg = 0;
                Console.WriteLine();
                
            }
            double atlagszam = osszegszam / db;
            
            Console.WriteLine($"Az átlóban lévő számok átlaga: {Math.Round(atlagszam,2)} ");

            Console.ReadKey();
        }
    }
}
