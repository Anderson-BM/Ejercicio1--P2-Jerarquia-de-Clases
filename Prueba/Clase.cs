using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Clase
    {

        public string Identificador { get; set; }
        public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
        public List<Profesor> Profesores { get; set; } = new List<Profesor>();


        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }

        //  IMPRIME DATOS DE LA CLASE
        public void ImprimirDatos()
        {
            Console.WriteLine("------------------------------------------------------Clases:" + Identificador + "------------------------------------------------------");
            Console.WriteLine($"Clase: {Identificador}");

            foreach (var estudiante in Estudiantes)
            {
                estudiante.ImprimirDatos();
            }
            Console.WriteLine("Profesores:");
            foreach (var profesor in Profesores)
            {
                profesor.ImprimirDatos();

            }
        }
    }
}