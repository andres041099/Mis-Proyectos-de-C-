using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace clase6
{
    public class Tarea
    {
        private string descripcion;
        private bool completada;

        public Tarea(string descripcion)
        {
            this.descripcion = descripcion;
            this.completada = false;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public bool GetCompletada()
        {
            return completada;
        }

        public void SetCompletada(bool completada)
        {
            this.completada = completada;
        }

        public override string ToString()
        {
            return $"{descripcion} - {(completada ? "Completada" : "Pendiente")}";
        }

        public string ToFileString()
        {
            return $"{descripcion}|{completada}";
        }

        public static Tarea FromFileString(string fileString)
        {
            var partes = fileString.Split('|');
            var descripcion = partes[0];
            var completada = bool.Parse(partes[1]);
            return new Tarea(descripcion) { completada = completada };
        }
    }
}
