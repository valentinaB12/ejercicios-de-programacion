using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _6_ejercico_programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[3];
            string[] edad = new string[3];
            string buscar;
            bool validar = false;
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("digite el nombre.. " + (i + 1));
                nombre[i] = Console.ReadLine();
                
                Console.WriteLine("digite la edad.." + nombre[i]);
                edad[i] = Console.ReadLine();

                Console.WriteLine(nombre[i] + " con  " + edad[i] + "  años.  ");
            }
            Console.Clear();
            Console.WriteLine("digite el nombre a buscar");
            buscar=Console.ReadLine();

            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i]==buscar & validar==true)
                {
                    Console.WriteLine(nombre[i]);
                    Console.WriteLine("el nombre si existe");
                    validar = true;
                    
                }
                else
                {

                    Console.WriteLine("el nombre no existe");
                    validar = false;
                }
            }
            

            Console.ReadKey();
            
            
            
        }
    }
}
