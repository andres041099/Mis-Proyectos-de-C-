using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase3
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string color;
        public double estatura;
        public double peso;
        public double[] notas = new double[3];

        //ACCESO(public, private, protected) TIPODATORETORNO (cualquier objeto strin, int, bool, objeto plantilla, void) identificador (PARAMETROS){cuerpo}
        public void respirar() 
        {
            Console.WriteLine($"{nombre} esta respirando");
        }

        public void presentate()
        {
            Console.WriteLine($"Nombre : {nombre}");
            Console.WriteLine($"Edad : {edad}");
            Console.WriteLine($"Color : {color}");
        }

    }
}
