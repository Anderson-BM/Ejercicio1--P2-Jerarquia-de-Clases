using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Estudiante : Persona
    {
        public int NumeroUnico { get; set; }
        public Clase Clase { get; set; }

        //  IMPRIME DATOS DE EL ESTUDIANTE
        public override void ImprimirDatos()
        {
            Console.WriteLine("--------------------------------DATOS ESTUDIANTES:" + Nombre);
            base.ImprimirDatos();
            Console.WriteLine($"Número Único: {NumeroUnico}");
            Console.WriteLine($"Clase: {Clase.Identificador}");
        }

    }
}