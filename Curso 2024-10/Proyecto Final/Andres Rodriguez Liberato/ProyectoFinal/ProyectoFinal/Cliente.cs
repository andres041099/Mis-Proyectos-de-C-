using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public List<CuentaBancaria> Cuentas { get; private set; }

        public Cliente(string nombre)
        {
            Nombre = nombre;
            Cuentas = new List<CuentaBancaria>();
        }

        public void AgregarCuenta(CuentaBancaria cuenta)
        {
            Cuentas.Add(cuenta);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Cliente: {Nombre}");
            foreach (var cuenta in Cuentas)
            {
                sb.AppendLine(cuenta.ToString());
            }
            return sb.ToString();
        }
    }
}
