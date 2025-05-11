/*Andres Rodriguez Liberato, Matricula 100520391*/
using System;

public class Triangulo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("------------Calcular Del Area Del Triangulo----------------------");
        Console.WriteLine("Escribe tu Base: ");
        double baseTriangulo= double.Parse(Console.ReadLine());
        Console.WriteLine("Escribe tu Altura: ");
        double alturaTriangulo= double.Parse(Console.ReadLine());
        Console.WriteLine("-----------------------------------------------------------------");
        CalcularArea(baseTriangulo, alturaTriangulo);
        Console.WriteLine("Programa Hecho por Andres Rodriguez Liberato, Matricula 100520391");
        Console.WriteLine("Gracias por Usar Mi Programa. Usalo Pronto.....");
        Console.WriteLine("-----------------------------------------------------------------");
    }

    public static void CalcularArea(Double bas, double altura) { 
    double Area = (bas * altura) / 2;
        Console.WriteLine("Tu Area Es: "+ Area);
    }
}


