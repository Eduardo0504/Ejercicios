int numeros = 0;
int cantidad = 0;
int contadorSuma = 0;
Console.WriteLine("Escriba la cantidad de numeros a sumar? ");
cantidad = int.Parse(Console.ReadLine());
for (int contador = 1; contador <= cantidad; contador ++)
{
	Console.WriteLine($"Escriba el numero {contador}: ");
	numeros = int.Parse( Console.ReadLine());
	contadorSuma = contadorSuma + numeros;
}
Console.WriteLine($"el resultado de la suma es:" + contadorSuma );
