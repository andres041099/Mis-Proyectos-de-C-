/*Andres Rodriguez Liberato, Matricula 100520391*/
int numero;
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Programa Para Saber Si el Numero es Positivo, Negativo o Cero");
Console.WriteLine("-----------------------------------------------------------");
Console.Write("Ingrese Un Numero: ");
numero= Int32.Parse(Console.ReadLine());
if (numero > 0)
{
    Console.WriteLine("El Numero que Ingresaste Es"+" "+numero+ " " + "Positivo");
}
else if (numero == 0)
{
    Console.WriteLine("El Numero que Ingresaste Es" + " " + numero + " " + "Cero");
}
else
{
    Console.WriteLine("El Numero que Ingresaste Es" + " " + numero + " " + "Negativo");
}
Console.WriteLine("Programa Hecho por Andres Rodriguez Liberato, Matricula 100520391");
Console.WriteLine("Gracias por Usar Mi Programa. Usalo Pronto.....");
Console.WriteLine("-----------------------------------------------------------------");