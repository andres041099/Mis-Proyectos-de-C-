using System;
using System.Collections.Generic;
class Program
{
    static List<string> Estudiantes = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("---------------Bienvenido a Registro Estudiante---------------");
            Console.WriteLine("1-Registrar un nuevo usuario Estudante");
            Console.WriteLine("2-Eliminar usuario Estudante");
            Console.WriteLine("3-Mostrar lista de Estudiantes");
            Console.WriteLine("4-Desarroyador de Programa");
            Console.WriteLine("5-Salir");
            Console.Write("¿Que desea hacer?: ");
            string seleciona = Console.ReadLine();
            switch (seleciona)
            {
                case "1":
                    registrarEstudiante();
                    break;
                case "2":
                    eliminarEstudiante();
                    break;
                case "3":
                    mostarEstudiante();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Error. Selecciona un opcion" + seleciona + "inesperada porfavor intenlelo denuevo intentelo denuevo");
                    break;

            }
        }


        static void registrarEstudiante()
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ingrese los nombres completos de {cantidadEstudiantes} estudiantes:");

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write($"Nombre del estudiante {i + 1}: ");
                Estudiantes.Add(Console.ReadLine());
            }
        }

        static void eliminarEstudiante()
        {
            Console.Write("Ingrese el nombre del estudiante a eliminar: ");
            string nombre = Console.ReadLine();

            if (Estudiantes.Remove(nombre))
            {
                Console.WriteLine($"Estudiante {nombre} eliminado.");
            }
            else
            {
                Console.WriteLine($"Estudiante {nombre} no encontrado.");
            }
        }

        static void mostarEstudiante()
        {
            if (Estudiantes.Count == 0)
            {
                Console.WriteLine("\nNo hay estudiantes registrados.");
            }
            else
            {
                Console.WriteLine("\nEstudiantes registrados:");
                foreach (string estudiante in Estudiantes)
                {
                    Console.WriteLine($"- {estudiante}");
                }
            }
        }


        static void mensajeDeSalida()
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Programa Hecho por Andres Rodriguez Liberato, Matricula 100520391");
            Console.WriteLine("Gracias por Usar Mi Programa. Usalo Pronto.....");
            Console.WriteLine("-----------------------------------------------------------------");
            Environment.Exit(0);
        }

    }
}


