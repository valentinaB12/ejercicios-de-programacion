using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _7__ejercicio_programacion
{
    class Program
    {
        
        private string[] nombres;
        private int[] edades;
        public void Cargar()
        {
            nombres = new string[5];
            edades = new int[5];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese nombre:");
                nombres[f] = Console.ReadLine();
                Console.Write("Ingrese edad:");
                string linea;
                linea = Console.ReadLine();
                edades[f] = int.Parse(linea);
            }
        }
        public void MayoresEdad()
        {
            
           Console.WriteLine("Persona mayor de edad.");
            for (int f = 0; f < nombres.Length; f++)
            {
                if (edades[f] >= 18)
                {
                    Console.WriteLine(nombres[f]);
                }
            }
            Console.ReadKey();
        }

        public void MenoresEdad()
        {

            Console.WriteLine("Persona menor de edad.");
            for (int f = 0; f < nombres.Length; f++)
            {
                if (edades[f] < 18)
                {
                    Console.WriteLine(nombres[f]);
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Cargar();
            pv.MayoresEdad();
            pv.MenoresEdad();
        }


    }
}

