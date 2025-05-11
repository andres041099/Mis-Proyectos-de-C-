using ProyectoFinal;

class Tester
{
    static void Main(string[] args)
    {
        GestorCuentas gestor = new GestorCuentas();
        Servicio servicio = new Servicio();

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Agregar Cuenta a Cliente");
            Console.WriteLine("3. Realizar Transferencia");
            Console.WriteLine("4. Mostrar Clientes");
            Console.WriteLine("5. Comprar Recarga");
            Console.WriteLine("6. Pagar Préstamo");
            Console.WriteLine("7. Pagar Tarjeta");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarCliente(gestor);
                    break;
                case 2:
                    AgregarCuenta(gestor);
                    break;
                case 3:
                    RealizarTransferencia(gestor);
                    break;
                case 4:
                    gestor.MostrarClientes();
                    break;
                case 5:
                    ComprarRecarga(gestor, servicio);
                    break;
                case 6:
                    PagarPrestamo(gestor, servicio);
                    break;
                case 7:
                    PagarTarjeta(gestor, servicio);
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        }
    }

    static void AgregarCliente(GestorCuentas gestor)
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();
        Cliente cliente = new Cliente(nombre);
        gestor.AgregarCliente(cliente);
        Console.WriteLine("Cliente agregado.");
    }

    static void AgregarCuenta(GestorCuentas gestor)
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();
        var cliente = gestor.BuscarCliente(nombre);

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

    static void RealizarTransferencia(GestorCuentas gestor)
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

        gestor.RealizarTransferencia(nombreOrigen, cuentaOrigen, nombreDestino, cuentaDestino, monto);
    }

    static void ComprarRecarga(GestorCuentas gestor, Servicio servicio)
    {
        var cuenta = SeleccionarCuenta(gestor);
        if (cuenta == null) return;

        Console.WriteLine("Seleccione la operadora:");
        Console.WriteLine("1. Claro");
        Console.WriteLine("2. Altice");
        int operadoraOpcion = int.Parse(Console.ReadLine());
        string operadora = operadoraOpcion == 1 ? "Claro" : "Altice";

        Console.Write("Ingrese el monto de la recarga: ");
        decimal monto = decimal.Parse(Console.ReadLine());

        servicio.ComprarRecarga(cuenta, operadora, monto);
    }

    static void PagarPrestamo(GestorCuentas gestor, Servicio servicio)
    {
        var cuenta = SeleccionarCuenta(gestor);
        if (cuenta == null) return;

        Console.Write("Ingrese el monto a pagar en el préstamo: ");
        decimal monto = decimal.Parse(Console.ReadLine());

        servicio.PagarPrestamo(cuenta, monto);
    }

    static void PagarTarjeta(GestorCuentas gestor, Servicio servicio)
    {
        var cuenta = SeleccionarCuenta(gestor);
        if (cuenta == null) return;

        Console.Write("Ingrese el monto a pagar en la tarjeta: ");
        decimal monto = decimal.Parse(Console.ReadLine());

        servicio.PagarTarjeta(cuenta, monto);
    }

    static CuentaBancaria SeleccionarCuenta(GestorCuentas gestor)
    {
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();
        var cliente = gestor.BuscarCliente(nombre);

        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado.");
            return null;
        }

        Console.Write("Ingrese el número de cuenta: ");
        string numeroCuenta = Console.ReadLine();
        var cuenta = cliente.Cuentas.Find(c => c.NumeroCuenta == numeroCuenta);

        if (cuenta == null)
        {
            Console.WriteLine("Cuenta no encontrada.");
        }

        return cuenta;
    }
}
