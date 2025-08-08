int retiro = 0;
int saldo = 100;
Console.WriteLine("cuanto dinero desea retirar? ");
retiro= int.Parse(Console.ReadLine());

if ( saldo < retiro )
{
	Console.WriteLine("su saldo es insuficiente");
}
else
{
	Console.WriteLine("su retiro fue exitoso");
}
