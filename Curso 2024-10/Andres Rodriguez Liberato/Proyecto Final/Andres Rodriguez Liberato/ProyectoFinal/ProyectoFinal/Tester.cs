using ProyectoFinal;

class Tester
{
    static void Main(string[] args)
    {
        GestorCuentas gestorCuentas = new GestorCuentas();

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Agregar Cuenta a Cliente");
            Console.WriteLine("3. Realizar Transferencia");
            Console.WriteLine("4. Mostrar Clientes");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarCliente(gestorCuentas);
                    break;
                case 2:
                    AgregarCuenta(gestorCuentas);
                    break;
                case 3:
                    RealizarTransferencia(gestorCuentas);
                    break;
                case 4:
                    gestorCuentas.MostrarClientes();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        }
    }

    static void AgregarCliente(GestorCuentas gestorCuentas)
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();
        Cliente cliente = new Cliente(nombre);
        gestorCuentas.AgregarCliente(cliente);
        Console.WriteLine("Cliente agregado.");
    }

    static void AgregarCuenta(GestorCuentas gestorCuentas)
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();
        var cliente = gestorCuentas.BuscarCliente(nombre);

        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado.");
            return;
        }

        Console.WriteLine("Seleccione el tipo de cuenta:");
        Console.WriteLine("1. Cuenta de Ahorro");
        Console.WriteLine("2. Cuenta Corriente");
        int tipoCuenta = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de cuenta: ");
        string numeroCuenta = Console.ReadLine();
        Console.Write("Ingrese el saldo inicial: ");
        decimal saldoInicial = decimal.Parse(Console.ReadLine());

        switch (tipoCuenta)
        {
            case 1:
                Console.Write("Ingrese la tasa de interés: ");
                decimal tasaInteres = decimal.Parse(Console.ReadLine());
                cliente.AgregarCuenta(new CuentaAhorro(numeroCuenta, nombre, saldoInicial, tasaInteres));
                break;
            case 2:
                Console.Write("Ingrese el límite de sobregiro: ");
                decimal limiteSobregiro = decimal.Parse(Console.ReadLine());
                cliente.AgregarCuenta(new CuentaCorriente(numeroCuenta, nombre, saldoInicial, limiteSobregiro));
                break;
            default:
                Console.WriteLine("Tipo de cuenta no válido.");
                break;
        }

        Console.WriteLine("Cuenta agregada.");
    }

    static void RealizarTransferencia(GestorCuentas gestorCuentas)
    {
        Console.Write("Ingrese el nombre del cliente de origen: ");
        string nombreOrigen = Console.ReadLine();
        Console.Write("Ingrese el número de cuenta de origen: ");
        string cuentaOrigen = Console.ReadLine();
        Console.Write("Ingrese el nombre del cliente de destino: ");
        string nombreDestino = Console.ReadLine();
        Console.Write("Ingrese el número de cuenta de destino: ");
        string cuentaDestino = Console.ReadLine();
        Console.Write("Ingrese el monto a transferir: ");
        decimal monto = decimal.Parse(Console.ReadLine());

        gestorCuentas.RealizarTransferencia(nombreOrigen, cuentaOrigen, nombreDestino, cuentaDestino, monto);
    }
}
