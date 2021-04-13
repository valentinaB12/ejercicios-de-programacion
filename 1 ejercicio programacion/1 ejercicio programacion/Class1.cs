using System;
using System.Collections.Generic;
using System.Text;

namespace _2_ejercicio_programacion
{
    class Class1
    {
        static void Main(string[] args)
        { int resultado = 0;
            int num = 0;
            Console.WriteLine("digite un numero");
             num = int.Parse(Console.ReadLine());
            for (int i =1; i <= 10;i++)
            {
                resultado = num * i;
                Console.WriteLine("la multiplicacion es {0}*{1}={2}", num, i, resultado);
            
            }
            Console.ReadKey();
        
        
        }


    }
}
