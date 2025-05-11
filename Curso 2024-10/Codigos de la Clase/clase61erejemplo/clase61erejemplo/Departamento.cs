using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase61erejemplo
{
    public class Departamento
    {
        private string Nombre;
        private List<Profesor> Profesores;

        public Departamento(string nombre)
        {
            this.Nombre = nombre;
            Profesores = new List<Profesor>();
        }
        ~Departamento() 
        {
            Profesores.Clear();
        }

        public void AgregarProfesor(Profesor profe)
        {
            Profesores.Add(profe);
        }
        public string getNombre()
        {
            return this.Nombre;
        }
        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public override string ToString()
        {
            return $"{Nombre} - Profesores: {string.Join(", ",Profesores)}";
        }
    }
}
