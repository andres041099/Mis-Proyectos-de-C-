        int[] edades = new int[10];
        int niños = 0;
        int adolescentes = 0;
        int adultos = 0;
        int adultosMayores = 0;

        Console.WriteLine("Ingrese 10 edades:");

        for (int i = 0; i <= 10; i++)
        {
            Console.Write($"Edad {i + 1}: ");
            edades[i] = int.Parse(Console.ReadLine());

            if (edades[i] >= 0 && edades[i] <= 12)
            {
                niños++;
            }
            else if (edades[i] >= 13 && edades[i] <= 17)
            {
                adolescentes++;
            }
            else if (edades[i] >= 18 && edades[i] <= 64)
            {
                adultos++;
            }
            else if (edades[i] >= 65)
            {
                adultosMayores++;
            }
            else
            {
                Console.WriteLine("Edad no válida.");
            }
        }

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Niños (0-12): {niños}");
        Console.WriteLine($"Adolescentes (13-17): {adolescentes}");
        Console.WriteLine($"Adultos (18-64): {adultos}");
        Console.WriteLine($"Adultos Mayores (65+): {adultosMayores}");



