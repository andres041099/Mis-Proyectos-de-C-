using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composicionejemplo
{
    public class Carro
    {
        public string marca { get; set; }
        public Motor motor { get; set; }
        public Rueda rueda { get; set; }

        public Carro(string marca, string tipoMotor, byte cantRuedas) 
        {
            this.marca = marca;
            motor = new Motor(tipoMotor);
            rueda = new Rueda(cantRuedas);
        }

        public override string ToString()
        {
            return $"{this.marca} con motor {this.motor} y con {rueda} gomas."; 
        }

    }
}
