int anoEscogido;
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Programa Para Saber Si un año es Biciesto o no");
Console.WriteLine("-----------------------------------------------------------");
Console.Write("Ingrese El Año: ");
anoEscogido = Int32.Parse(Console.ReadLine());
if ((anoEscogido % 4 == 0 && anoEscogido % 100 != 0) || (anoEscogido % 400 == 0))
{
    Console.WriteLine("EL año" + " " +anoEscogido+" "+"Es Biciesto");
}
else
{
    Console.WriteLine("EL año" + " " + anoEscogido + " " + "No Es Biciesto");
}

Console.WriteLine("Programa Hecho por Andres Rodriguez Liberato, Matricula 100520391");
Console.WriteLine("Gracias por Usar Mi Programa. Usalo Pronto.....");
Console.WriteLine("-----------------------------------------------------------------");
