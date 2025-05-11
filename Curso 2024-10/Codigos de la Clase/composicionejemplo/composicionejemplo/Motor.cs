using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composicionejemplo
{
    public class Motor
    {
        public string Tipo { get; set; }

        public Motor(string tipo)
        {
            Tipo = tipo;
        }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
