using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase61erejemplo
{
    public class Profesor
    {
        private string Nombre;
        private short edad;

        public Profesor(string nombre, short edad) 
        {
            this.Nombre = nombre;
            this.edad = edad;
        }
        public string getNombre() 
        {
            return this.Nombre; 
        }
        public short getEdad()
        {
            return this.edad;
        }
        public void setNombre(string nombre)
        {
            this.Nombre= nombre;
        }
        public void setEdad(short edad)
        {
            this.edad = edad;   
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} \nEdad: {this.edad}"; 
        }
        /*public string getInfo() 
        {
            return $"Nombre: {this.Nombre} \nEdad: {this.edad}";
        }*/
    }
}
