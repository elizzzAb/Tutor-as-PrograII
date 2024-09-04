using System;
using static System.Console;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determinar si un número es par o impar.
            WriteLine("Ingresa un número: ");
            int valor = int.Parse(ReadLine());

            if (valor % 2 == 0 )
            {
                WriteLine("En número ingresado es par.");
            }
            else
            {
                WriteLine("El número ingresado es impar.");
            }
        }
    }
}