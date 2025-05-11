using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaClase6
{
    public class CuentaBancaria
    {
        protected string NumeroCuenta { get; set; }
        public double Saldo { get; set; }

        public CuentaBancaria(string NumeroCuenta) 
        {
            this.NumeroCuenta = NumeroCuenta;
            Saldo = 0;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Cuenta: {this.NumeroCuenta}, Saldo: RD${this.Saldo}");
        }

        public void SoyPadre() {
            Console.WriteLine("Soy el padre");
        }
 
    }
}
