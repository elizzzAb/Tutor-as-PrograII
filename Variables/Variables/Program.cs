//Tutoría PrograII. 03-09-24
//Variables:
//Sniper: atajo

using System;
using static System.Console;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cálculo de Conversión de Temperatura: Escribe un programa que pida al usuario
            // una temperatura en grados Celsius y la convierta a Fahrenheit.
            // Usa la fórmula: (0 °C × 9/5) + 32
            Console.WriteLine("Ingresa una temperatura en grados Celsius: ");
            //Console.ReadLine();
            float celsius = float.Parse(ReadLine()); //lo estamos parciando, convirtiendolo en str
            float fahrenheit = (celsius * 9 / 5) + 32; //
            WriteLine($"Tu temperatura en fahrenheit es: { fahrenheit}"); //interpolacion de cadenas (inserta expresion directamente en el string '$')

            //string telefono = "+503 2356-9326"; //Para numeros de telefono, no usar int xq el usuario puede ser como yo xd


        }
    }
}
