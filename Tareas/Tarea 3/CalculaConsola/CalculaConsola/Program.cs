using System;

class Sumadora
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora Simple");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción (1-5): ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 5)
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }

            Console.Write("Ingresa el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = Sumar(num1, num2);
                    break;
                case 2:
                    resultado = Restar(num1, num2);
                    break;
                case 3:
                    resultado = Multiplicar(num1, num2);
                    break;
                case 4:
                    resultado = Dividir(num1, num2);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                    continue;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }
    }

    static double Sumar(double a, double b)
    {
        return a + b;
    }

    static double Restar(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double Dividir(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("No se puede dividir por cero.");
            return 0;
        }
    }
}

