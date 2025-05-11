using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composicionejemplo
{
    public class Rueda
    {
        public byte cantidad { get; set; }

        public Rueda(byte cantidad)
        {
            this.cantidad = cantidad;
        }

        public override string ToString()
        {
            return Convert.ToString(cantidad);
        }
    }
}
