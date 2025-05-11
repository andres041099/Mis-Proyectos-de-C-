using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaClase6
{
    public class cuentaAhorro : CuentaBancaria
    {
        public double TasaInteres { get; set; }

        public cuentaAhorro(string numeroCuenta, double tasaInteres) : base(numeroCuenta)
        {
            this.TasaInteres = tasaInteres;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine($"Cuenta: {this.NumeroCuenta}, Saldo: RD${this.Saldo}, Tasa de Interes: {this.TasaInteres}");
            base.SoyPadre();
        }
    }
}
