using System;

namespace _1_ejercicio_programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("digite un numero");
            double num = double.Parse(Console.ReadLine());

            if ((num % 2) == 0)
            {
                Console.WriteLine("el numero es par");

            }
            else
            {
                Console.WriteLine("el numero es impar");

            }
            Console.ReadKey();
    }   }
}
