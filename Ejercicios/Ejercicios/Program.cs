var valorDelAutomovil = 20000;
var valorDeRescateDelAutomovil = 2000;

var valorDeRecuperacion = valorDelAutomovil - valorDeRescateDelAutomovil ;

var añosDeRecuperacion = 6;

double resultadoDeLaRecuperacion = (double)valorDeRecuperacion / añosDeRecuperacion;



Console.WriteLine($"el valor de depriacion constante de cada año es: {resultadoDeLaRecuperacion}");