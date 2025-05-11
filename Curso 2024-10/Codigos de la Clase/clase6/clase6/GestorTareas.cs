using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase6
{
    public class GestorTareas
    {
        private List<Tarea> tareas = new List<Tarea>();
        private string archivo = "tareas.txt";

        public void AgregarTarea(Tarea tarea)
        {
            tareas.Add(tarea);
            Console.WriteLine($"Tarea agregada: {tarea.GetDescripcion()}");
        }

        public void MostrarTareas()
        {
            Console.WriteLine("Lista de Tareas:");
            foreach (var tarea in tareas)
            {
                Console.WriteLine(tarea);
            }
        }

        public void GuardarTareas()
        {
            using (StreamWriter writer = new StreamWriter(archivo))
            {
                foreach (var tarea in tareas)
                {
                    writer.WriteLine(tarea.ToFileString());
                }
            }
            Console.WriteLine("Tareas guardadas en el archivo.");
        }

        public void CargarTareas()
        {
            if (!File.Exists(archivo))
            {
                Console.WriteLine("No se encontró el archivo de tareas. Se creará uno nuevo.");
                return;
            }

            using (StreamReader reader = new StreamReader(archivo))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    var tarea = Tarea.FromFileString(linea);
                    tareas.Add(tarea);
                }
            }
            Console.WriteLine("Tareas cargadas desde el archivo.");
        }
    }
}
