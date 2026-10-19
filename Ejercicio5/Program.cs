
Console.WriteLine("CALCULO DE DESCUENTO DEL 10%");

Console.Write("Ingrese el precio del producto: ");
double precio = Convert.ToDouble(Console.ReadLine());

double descuento = precio * 0.10;
double precioFinal = precio - descuento;

Console.WriteLine("El descuento es: RD$" + descuento);
Console.WriteLine("El precio final es: RD$" + precioFinal);
