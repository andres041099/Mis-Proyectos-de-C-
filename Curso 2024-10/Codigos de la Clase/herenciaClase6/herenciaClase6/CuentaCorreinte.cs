using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaClase6
{
    public class CuentaCorriente : CuentaBancaria
    {
        public double limiteConcurrencia { get; set; }

        public CuentaCorriente(string numeroCuenta, double limiteConcurrencia) : base(numeroCuenta)
        {
            this.limiteConcurrencia = limiteConcurrencia;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Limite Concurrencia: {this.limiteConcurrencia}");
        }
    }


}
