using System;

namespace _4_ejercicio_de_programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0,j;
            j = 0;
            Console.WriteLine("digite un numero");
            num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    j++;

                }

            }


                 if (j==2)
                 {
                    Console.WriteLine("el numer es primo");

                 }
                else
                {
                    Console.WriteLine("el numero no es primo");
                
                }

            Console.ReadKey();
    }   }
}           
