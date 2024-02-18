// See https://aka.ms/new-console-template for more information
using ejemplo_herencia;


Console.WriteLine("OPERACIONES ARITMETICAS");
Console.WriteLine();

int resultado_suma, resultado_resta, resultado_multiplicación;

suma suma = new suma();
Console.WriteLine("operacion suma");
Console.WriteLine();
Console.Write("Valor 1: ");
suma.Valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor 2: ");
suma.Valor2 = Convert.ToInt32(Console.ReadLine());
resultado_suma = suma.operar();
Console.WriteLine($"El resultado de la suma es {resultado_suma}");
Console.WriteLine();

Resta resta = new Resta();
Console.WriteLine("operacion resta");
Console.WriteLine();
Console.Write("Valor 1: ");
resta.Valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor 2: ");
resta.Valor2 = Convert.ToInt32(Console.ReadLine());
resultado_resta = resta.operar();
Console.WriteLine($"El resultado de la resta es {resultado_resta}");
Console.WriteLine();

Multiplicación multiplicación = new Multiplicación();
Console.WriteLine("operacion multiplicación");
Console.WriteLine();
Console.Write("Valor 1: ");
multiplicación.Valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Valor 2: ");
multiplicación.Valor2 = Convert.ToInt32(Console.ReadLine());
resultado_multiplicación = multiplicación.operar();
Console.WriteLine($"El resultado de la Multiplicación es {resultado_multiplicación}");
Console.WriteLine();

