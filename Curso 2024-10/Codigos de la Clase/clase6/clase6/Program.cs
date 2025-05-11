using clase6;

GestorTareas gestor = new GestorTareas();
gestor.CargarTareas();

bool salir = false;
while (!salir)
{
    Console.WriteLine("1. Agregar Tarea");
    Console.WriteLine("2. Mostrar Tareas");
    Console.WriteLine("3. Guardar Tareas");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese la descripción de la tarea: ");
            string descripcion = Console.ReadLine();
            gestor.AgregarTarea(new Tarea(descripcion));
            break;
        case "2":
            gestor.MostrarTareas();
            break;
        case "3":
            gestor.GuardarTareas();
            break;
        case "4":
            salir = true;
            gestor.GuardarTareas();
            break;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }
}