using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class CuentaAhorro : CuentaBancaria
    {
        public decimal TasaInteres { get; private set; }

        public CuentaAhorro(string numeroCuenta, string titular, decimal saldoInicial, decimal tasaInteres) : base(numeroCuenta, titular, saldoInicial)
        {
            TasaInteres = tasaInteres;
        }

        public void AplicarInteres()
        {
            Saldo += Saldo * TasaInteres;
        }

        public override string ToString()
        {
            return base.ToString() + $", Tasa de Interés: {TasaInteres:P}";
        }
    }
}
