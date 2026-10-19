
using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULO DEL AREA");

            Console.Write("Ingrese la base: ");
            double baseFigura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = baseFigura * altura;

            Console.WriteLine("El area es: " + area);

            Console.ReadKey();
        }
    }
}
