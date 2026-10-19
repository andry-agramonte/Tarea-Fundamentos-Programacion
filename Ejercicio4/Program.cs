
Console.WriteLine("CONVERSION DE DOLARES A PESOS");

Console.Write("Ingrese la cantidad de dolares: ");
double dolares = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la tasa de cambio: ");
double tasaCambio = Convert.ToDouble(Console.ReadLine());

double pesos = dolares * tasaCambio;

Console.WriteLine("El equivalente en pesos dominicanos es: RD$" + pesos);
