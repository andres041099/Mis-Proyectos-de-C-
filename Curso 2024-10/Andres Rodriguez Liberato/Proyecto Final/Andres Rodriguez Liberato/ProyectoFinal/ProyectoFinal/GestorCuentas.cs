using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class GestorCuentas
    {
        public List<Cliente> Clientes { get; private set; }

        public GestorCuentas()
        {
            Clientes = new List<Cliente>();
        }

        public void AgregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public Cliente BuscarCliente(string nombre)
        {
            return Clientes.Find(c => c.Nombre == nombre);
        }

        public void RealizarTransferencia(string nombreClienteOrigen, string numeroCuentaOrigen, string nombreClienteDestino, string numeroCuentaDestino, decimal monto)
        {
            var clienteOrigen = BuscarCliente(nombreClienteOrigen);
            var clienteDestino = BuscarCliente(nombreClienteDestino);

            if (clienteOrigen == null || clienteDestino == null)
            {
                Console.WriteLine("Uno o ambos clientes no encontrados.");
                return;
            }

            var cuentaOrigen = clienteOrigen.Cuentas.Find(c => c.NumeroCuenta == numeroCuentaOrigen);
            var cuentaDestino = clienteDestino.Cuentas.Find(c => c.NumeroCuenta == numeroCuentaDestino);

            if (cuentaOrigen == null || cuentaDestino == null)
            {
                Console.WriteLine("Una o ambas cuentas no encontradas.");
                return;
            }

            if (cuentaOrigen.Transferir(cuentaDestino, monto))
            {
                Console.WriteLine("Transferencia realizada con éxito.");
            }
            else
            {
                Console.WriteLine("No se pudo realizar la transferencia. Verifique los fondos.");
            }
        }

        public void MostrarClientes()
        {
            foreach (var cliente in Clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }
    }
}
