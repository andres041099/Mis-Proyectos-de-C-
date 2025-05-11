using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class CuentaBancaria
    {
        public string NumeroCuenta { get; private set; }
        public string Titular { get; private set; }
        public decimal Saldo { get; protected set; }

        public CuentaBancaria(string numeroCuenta, string titular, decimal saldoInicial)
        {
            NumeroCuenta = numeroCuenta;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public virtual void Depositar(decimal monto)
        {
            Saldo += monto;
        }

        public virtual bool Retirar(decimal monto)
        {
            if (Saldo >= monto)
            {
                Saldo -= monto;
                return true;
            }
            return false;
        }

        public virtual bool Transferir(CuentaBancaria destino, decimal monto)
        {
            if (Retirar(monto))
            {
                destino.Depositar(monto);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Cuenta: {NumeroCuenta}, Titular: {Titular}, Saldo: {Saldo:C}";
        }
    }
}
