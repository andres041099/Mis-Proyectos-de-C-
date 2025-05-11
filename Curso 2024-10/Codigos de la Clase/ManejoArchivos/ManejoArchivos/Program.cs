// Especificar la ruta del archivo
string filePath = "C:\\Users\\Esdras\\source\\repos\\ManejoArchivos\\ManejoArchivos\\ruta_del_archivo.txt";

// Verificar si el archivo existe
if (File.Exists(filePath))
{
    // Leer todo el contenido del archivo
    string fileContent = File.ReadAllText(filePath);

    // Mostrar el contenido del archivo en la consola
    Console.WriteLine("Contenido del archivo:");
    Console.WriteLine(fileContent);
}
else
{
    Console.WriteLine("El archivo no existe en la ruta especificada.");
}

// Esperar a que el usuario presione una tecla antes de cerrar la consola
Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();

//FUNCIONES DE ENTRADA Y SALIDA
/*
filePath = "C:\\Users\\Esdras\\source\\repos\\ManejoArchivos\\ManejoArchivos\\ejemplo.txt";

// Crear y escribir en el archivo
CreateAndWriteFile(filePath);

// Leer el archivo
ReadFile(filePath);

// Actualizar el archivo
UpdateFile(filePath);

// Leer el archivo actualizado
ReadFile(filePath);

// Eliminar el archivo
DeleteFile(filePath);

static void CreateAndWriteFile(string path)
{
// Crear y escribir en el archivo
using (StreamWriter sw = new StreamWriter(path))
{
    sw.WriteLine("Línea 1");
    sw.WriteLine("Línea 2");
    sw.WriteLine("Línea 3");
}
Console.WriteLine("Archivo creado y escrito.");
}

static void ReadFile(string path)
{
    if (File.Exists(path))
    {
        // Leer el archivo
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            Console.WriteLine("Contenido del archivo:");
            while (sr.ReadLine() != null)
            {
                line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
    else
    {
        Console.WriteLine("El archivo no existe.");
    }
}

static void UpdateFile(string path)
{
    if (File.Exists(path))
    {
        // Actualizar el archivo añadiendo una nueva línea
        using (StreamWriter sw = File.AppendText(path))
        {
            sw.WriteLine("Línea actualizada");
        }
        Console.WriteLine("Archivo actualizado.");
    }
    else
    {
        Console.WriteLine("El archivo no existe.");
    }
}

static void DeleteFile(string path)
{
    if (File.Exists(path))
    {
        // Eliminar el archivo
        File.Delete(path);
        Console.WriteLine("Archivo eliminado.");
    }
    else
    {
        Console.WriteLine("El archivo no existe.");
    }
}*/