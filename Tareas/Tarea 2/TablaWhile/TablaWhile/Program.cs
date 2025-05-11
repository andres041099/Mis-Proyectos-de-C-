/*Andres Rodriguez Liberato, Matricula 100520391*/
int numero;
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Tabla While Para Calcular");
Console.WriteLine("-----------------------------------------------------------");
Console.Write("Ingrese el número para la tabla de multiplicar: ");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tabla de multiplicar del " + numero + ":");

int contador = 1;
while (contador <= 12)
{
    int resultado = numero * contador;
    Console.WriteLine(numero + " x " + contador + " = " + resultado);
    contador++;
}
Console.WriteLine("Programa Hecho por Andres Rodriguez Liberato, Matricula 100520391");
Console.WriteLine("Gracias por Usar Mi Programa. Usalo Pronto.....");
Console.WriteLine("-----------------------------------------------------------------");