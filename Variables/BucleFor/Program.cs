using System;
using static System.Console;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tabla de mulriplicar: Escrieb un programa que pida la usuario un numero y
            //luego muestre la tabla de muktiplicar de ese numeri del 1 al 10.
            WriteLine("Ingresa un valor: ");
            int valor = int.Parse(ReadLine());

            WriteLine($"___TABLA___\n ");
            for (int i = 1; i <= 10; i++)
            {
                int resultado = valor * i;
                WriteLine($"{valor} x {i} = {resultado}");

            }
            
        }
    }
}