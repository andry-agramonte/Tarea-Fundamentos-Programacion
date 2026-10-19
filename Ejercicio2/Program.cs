
using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad + " años");

            Console.ReadKey();
        }
    }
}
