        int[] calificaciones = new int[5];
        int suma = 0;

    
        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.Write($"Ingrese la calificación {i + 1}: ");
            calificaciones[i] = int.Parse(Console.ReadLine());
            suma += calificaciones[i];
        }

   
        double promedio = suma / (double)calificaciones.Length;

       
        Console.WriteLine($"El promedio es: {promedio:F2}");
        if (promedio >= 60)
        {
            Console.WriteLine("El estudiante aprobó.");
        }
        else
        {
            Console.WriteLine("El estudiante reprobó.");
        }

