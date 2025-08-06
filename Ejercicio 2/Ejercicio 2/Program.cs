int horas;
int  tarifa ;
const double tasa = 0.1;
int pagaBruta = 0;
double impuestos = 0;
double pagaNeta = 0;

Console.WriteLine("Escriba las horas trabajadas");
horas = int.Parse(Console.ReadLine());

Console.WriteLine("Escriba el pago por horas ");
tarifa = int.Parse(Console.ReadLine());

pagaBruta = horas * tarifa;

Console.WriteLine($"el salario pagado es de " + pagaBruta);

impuestos = pagaBruta * tasa;

Console.WriteLine($"El impuesto cobrado es de: " + impuestos);

pagaNeta = pagaBruta - impuestos;

Console.WriteLine($"Su paga neta es de: " + pagaNeta);
