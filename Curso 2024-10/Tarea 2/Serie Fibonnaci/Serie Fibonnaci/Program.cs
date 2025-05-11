using System;

public static class Fibonnaci
{
    public static void Main()
    {
        Console.Write("Introduce los numero los numeros: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("La serie Fibonacci usada en el bucle es:");
        FibonacciUsingWhile(numero);

        Console.WriteLine("\n la Serie Fibonacci usada por el bucle es:");
        FibonacciUsingFor(numero);
    }

    public static void FibonacciUsingWhile(int numero)
    {
        int n1 = 0, n2 = 1, n3, i = 2;

        Console.Write($"{n1} {n2} "); // Imprime los dos primeros números

        while (i < numero)
        {
            n3 = n1 + n2;
            Console.Write($"{n3} ");
            n1 = n2;
            n2 = n3;
            i++;
        }
    }

    public static void FibonacciUsingFor(int numero)
    {
        int n1 = 0, n2 = 1, n3;

        Console.Write($"{n1} {n2} "); // Imprime los dos primeros números

        for (int i = 2; i < numero; i++) // ya hemos impreso dos números
        {
            n3 = n1 + n2;
            Console.Write($"{n3} ");
            n1 = n2;
            n2 = n3;
        }
    }
}

