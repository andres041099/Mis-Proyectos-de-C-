using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
   public class CuentaCorriente : CuentaBancaria
    {
        public decimal LimiteSobregiro { get; private set; }

        public CuentaCorriente(string numeroCuenta, string titular, decimal saldoInicial, decimal limiteSobregiro)
            : base(numeroCuenta, titular, saldoInicial)
        {
            LimiteSobregiro = limiteSobregiro;
        }

        public override bool Retirar(decimal monto)
        {
            if (Saldo + LimiteSobregiro >= monto)
            {
                Saldo -= monto;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $", Límite de Sobregiro: {LimiteSobregiro:C}";
        }
    }
}
