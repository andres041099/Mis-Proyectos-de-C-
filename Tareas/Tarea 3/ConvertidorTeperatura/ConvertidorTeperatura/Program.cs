/*Andres Rodriguez Liberato, Matricula 100520391*/
using System;

public class Temperatura
{

    public static void Main(string[] args)
    {
        PantallaMenu();  
    }

    public static void PantallaMenu()
    {
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("------------Calcular La Temperatura----------------------");
        Console.WriteLine("Ingrese a la Opcion de  Temperatura que Quiera Convertir: ");
        Console.WriteLine("1- Convertir de Celcuius a Farenheit: ");
        Console.WriteLine("2- Convertir de Farenheit a Celcuius: ");
        Console.WriteLine("3- Salir: ");
        
        int opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion==1)
        { 
            Console.WriteLine("Ingrese una Temperatura que Quiera Convertir: ");
            double Grado1= double.Parse(Console.ReadLine());
            ConvertirCelcius(Grado1);
            return;
        }

        if (opcion == 2)
        {
            Console.WriteLine("Ingrese una Temperatura que Quiera Convertir: ");
            double Grado2 = double.Parse(Console.ReadLine());
            ConvertirCelcius(Grado2);
            return;
        }
        if(opcion == 3)
        {
            SalirPrograma();
        }
    }
    public static double ConvertirCelcius(double farenheit)
    {
     double Temperatura1 = (farenheit - 32) / 1.8;
        Console.Write("Tu Temperatura es: " +Temperatura1+" "+"F");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("Programa Hecho por Andres Rodriguez Liberato, Matricula 100520391");
        Console.WriteLine("Gracias por Usar Mi Programa. Usalo Pronto.....");
        Console.WriteLine("-----------------------------------------------------------------");
        return Temperatura1;
    }
    public static double ConvertirAFarenheit(double celcius)
    {
        double Temperatura2 = (celcius * 1.8) + 32;
        Console.Write("Tu Temperatura es: " + Temperatura2 + " " + "C");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("Programa Hecho por Andres Rodriguez Liberato, Matricula 100520391");
        Console.WriteLine("Gracias por Usar Mi Programa. Usalo Pronto.....");
        Console.WriteLine("-----------------------------------------------------------------");
        return Temperatura2;
    }

    public static void SalirPrograma()
    {
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("Programa Hecho por Andres Rodriguez Liberato, Matricula 100520391");
        Console.WriteLine("Gracias por Usar Mi Programa. Usalo Pronto.....");
        Console.WriteLine("-----------------------------------------------------------------");
        Environment.Exit(0);
    }
}



