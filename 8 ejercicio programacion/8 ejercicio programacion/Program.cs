using System;

namespace _8_ejercicio_programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra, inverso, carcater;
            int i;
            Console.WriteLine("digite la palabra");
            palabra = Convert.ToString(Console.ReadLine());
            i = palabra.Length;
            inverso = "";
            for (int x = i; x >= 0; x--)
            {
                carcater = palabra.Substring(x, 1);
                inverso = inverso + carcater;
            
            
            }
            if (palabra == inverso)
            {
                Console.WriteLine("es palindrome");

            }
            else 
            {
                Console.WriteLine("no es palindrome");
            
            }
            Console.ReadKey();
        }   
           
    }
}
