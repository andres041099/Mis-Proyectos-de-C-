using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, double> Productos = new Dictionary<string, double>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Eliminar Producto");
            Console.WriteLine("3. Actualizar Precio");
            Console.WriteLine("4. Listar Productos");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarProducto();
                    break;
                case 2:
                    EliminarProducto();
                    break;
                case 3:
                    ActualizarPrecio();
                    break;
                case 4:
                    ListarProductos();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        }
    }

    static void AgregarProducto()
    {
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        if (Productos.ContainsKey(nombre))
        {
            Console.WriteLine("El producto ya existe. Use la opción de actualizar precio.");
        }
        else
        {
            Productos[nombre] = precio;
            Console.WriteLine("Producto agregado.");
        }
    }

    static void EliminarProducto()
    {
        Console.Write("Ingrese el nombre del producto a eliminar: ");
        string nombre = Console.ReadLine();

        if (Productos.Remove(nombre))
        {
            Console.WriteLine("Producto eliminado.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    static void ActualizarPrecio()
    {
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();

        if (Productos.ContainsKey(nombre))
        {
            Console.Write("Ingrese el nuevo precio del producto: ");
            double nuevoPrecio = double.Parse(Console.ReadLine());
            Productos[nombre] = nuevoPrecio;
            Console.WriteLine("Precio actualizado.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    static void ListarProductos()
    {
        if (Productos.Count == 0)
        {
            Console.WriteLine("No hay productos registrados.");
        }
        else
        {
            Console.WriteLine("\nProductos registrados:");
            foreach (var producto in Productos)
            {
                Console.WriteLine($"{producto.Key}: {producto.Value:C}");
            }
        }
    }
}
