using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Servicio
    {
        public void ComprarRecarga(CuentaBancaria cuenta, string operadora, decimal monto)
        {
            if (cuenta.Retirar(monto))
            {
                Console.WriteLine($"Recarga de {monto} a {operadora} realizada con éxito.");
            }
            else
            {
                Console.WriteLine("No se pudo realizar la recarga. Fondos insuficientes.");
            }
        }

        public void PagarPrestamo(CuentaBancaria cuenta, decimal monto)
        {
            if (cuenta.Retirar(monto))
            {
                Console.WriteLine($"Pago de préstamo por {monto} realizado con éxito.");
            }
            else
            {
                Console.WriteLine("No se pudo realizar el pago del préstamo. Fondos insuficientes.");
            }
        }

        public void PagarTarjeta(CuentaBancaria cuenta, decimal monto)
        {
            if (cuenta.Retirar(monto))
            {
                Console.WriteLine($"Pago de tarjeta por {monto} realizado con éxito.");
            }
            else
            {
                Console.WriteLine("No se pudo realizar el pago de la tarjeta. Fondos insuficientes.");
            }
        }
    }
}
