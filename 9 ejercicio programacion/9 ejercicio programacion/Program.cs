using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _9_EJERCICIO_PROGRAMACION
{
    class Program
    {
        static void Main(string[] args)
        {
            byte can, j;
            int A, B, C;
            string linea;
            Console.WriteLine("CODIGO FIBONACHI");
            Console.Write("digite la cantidad de numeros: "); linea = Console.ReadLine();
            can = byte.Parse(linea);
            A = 1; B = 1;
            Console.Write(A + " " + B + " ");
            for (j = 3; j <= can; j++)
            {
                C = A + B;
                
                Console.Write(C + " ");
                
                A = B;
                B = C;
            }
            Console.ReadKey();
            
        }
    }
}
