using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Profesor : Persona
    {
        public List<Cursos> Cursos { get; set; } = new List<Cursos>();


        public void AgregarCurso(Cursos cursos)
        {
            Cursos.Add(cursos);
        }

        //  IMPRIME DATOS DE EL PROFESOR
        public override void ImprimirDatos() {

            Console.WriteLine("--------------------------------PROFESOR:" + Nombre  );

            // IMPRIMIR DATOS DE LOS CURSOS
            if (Cursos.Count > 0)
            {
                Console.WriteLine($"Cursos asignados a {Nombre}:");
                foreach (var curso in Cursos)
                {
                    Console.WriteLine($"- Curso: {curso.Nombre}");
                    Console.WriteLine($"- Recuento de clases: {curso.RecuentoClases}");
                    Console.WriteLine($"- Recuento de ejercicios: {curso.RecuentoEjercicios}");
                }
            }
            else
            {
                Console.WriteLine($"{Nombre} no tiene cursos asignados.");
            }

            Console.WriteLine();  // SALTO DE LINEA EXTRA

        }
    }
}
