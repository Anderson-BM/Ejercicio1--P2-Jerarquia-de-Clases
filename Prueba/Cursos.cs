using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Cursos
    {
        public string Nombre { get; set; }
        public int RecuentoClases { get; set; }
        public int RecuentoEjercicios { get; set; }

        //  IMPRIME DATOS DE EL CURSO
        public void ImprimirDatos()
        {
            Console.WriteLine($"Curso: {Nombre}");
            Console.WriteLine($"Recuento de Clases: {RecuentoClases}");
            Console.WriteLine($"Recuento de Ejercicios: {RecuentoEjercicios}");
        }

    }
}
