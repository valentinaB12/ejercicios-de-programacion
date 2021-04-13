using System;

namespace _3_ejercicio_de_programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 3;
            int num3 = 4;
            int num4 = 5;
            int num5 = 6;
            int num6 = 7;
            int num7 = 8;
            int num8 = 9;
            int resultado = 0;
            Console.WriteLine("Tablas de Multiplicar");
            Console.WriteLine("tabla de multiplicar del 2");
            for (int i = 1; i <= 10; i++)
            {
                resultado = num1 * i;
                Console.WriteLine("{0}*{1}={2}", num1, i, resultado);

            }
            Console.WriteLine("tabla de multiplicar del 3");
            for (int i = 1; i <= 10; i++)
            {
                resultado = num2 * i;
                Console.WriteLine("{0}*{1}={2}", num2, i, resultado);
            }
            Console.WriteLine("tabla de multiplicar del 4");
            for (int i = 1; i <= 10; i++)
            {
                resultado = num3 * i;
                Console.WriteLine("{0}*{1}={2}", num3, i, resultado);

            }
            Console.WriteLine("tabla de multiplicar del 5");
            for (int i = 1; i <= 10; i++)
            {
                resultado = num4 * i;
                Console.WriteLine("{0}*{1}={2}", num4, i, resultado);

            }
            Console.WriteLine("tabla de multiplicar del 6");
            for (int i = 1; i <= 10; i++)
            {
                resultado = num5 * i;
                Console.WriteLine("{0}*{1}={2}", num5, i, resultado);

            }
            Console.WriteLine("tabla de multiplicar del 7");
            for (int i = 1; i <= 10; i++)
            {
                resultado = num6 * i;
                Console.WriteLine("{0}*{1}={2}", num6, i, resultado);

            }
            Console.WriteLine("tabla de multiplicar del 8");
            for (int i = 1; i <= 10; i++)
            {
                resultado = num7 * i;
                Console.WriteLine("{0}*{1}={2}", num7, i, resultado);
            }
            Console.WriteLine("tabla de multiplicar del 9");
            for (int i = 1; i <= 10; i++)
            {
                resultado = num8 * i;
                Console.WriteLine("{0}*{1}={2}", num8, i, resultado);

            }
        }
}   }