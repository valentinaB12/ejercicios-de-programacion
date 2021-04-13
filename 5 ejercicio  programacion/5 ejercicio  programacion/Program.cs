using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace _5_ejercicio__programacion
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = 0;
            int[] num;
            int m = 0;
            Console.WriteLine("digite la cantidad de  numeros");
            n = int.Parse(Console.ReadLine());
            num = new int[n];
            for (int f = 0; f < num.Length; f++)
            {
                Console.Write("Ingrese numero " + (f + 1) + ": ");
                string linea = Console.ReadLine();
                num[f] = int.Parse(linea);
            }

            for (int x = 1; x < n - 1; x++)
            {
                for (int y = 0; y < n - 1; y++)
                {
                    if (num[x] < num[y])
                    {
                        m = num[x];
                        num[x] = num[y];
                        num[y] = m;

                    }
                }


            }

            for (int r = 0; r < n; r++) 
            {
                Console.WriteLine("{0}-{1}", r + 1, num[r]);
                Console.ReadKey();
            }





        }
    }
}
