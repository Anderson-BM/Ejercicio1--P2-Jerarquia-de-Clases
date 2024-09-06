using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Prueba
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // CLASES CREADAS
            Clase claseA = new Clase { Identificador = "D003" };
            Clase claseB = new Clase { Identificador = "D004" };


            // ESTUDIANTES CREADOS
            Estudiante estudiante1 = new Estudiante { Nombre = "Anderson Batista", NumeroUnico = 01, Clase = claseA };
            Estudiante estudiante2 = new Estudiante { Nombre = "Juan Baez", NumeroUnico = 02, Clase = claseA };
            Estudiante estudiante3 = new Estudiante { Nombre = "Carlos Ruiz", NumeroUnico = 03, Clase = claseA };
            Estudiante estudiante4 = new Estudiante { Nombre = "Moises Jabier", NumeroUnico = 04, Clase = claseB };
            Estudiante estudiante5 = new Estudiante { Nombre = "Francisco Peña", NumeroUnico = 05, Clase = claseB };
            Estudiante estudiante6 = new Estudiante { Nombre = "Orlando Palisa", NumeroUnico = 06, Clase = claseB };

            // PROFESORES CREADAS
            Profesor profesor1 = new Profesor { Nombre = "Freidy Nuñez" };
            Profesor profesor2 = new Profesor { Nombre = "Pedro Antonio" };
            Profesor profesor3 = new Profesor { Nombre = "Teofilo Diaz" };

            // CURSOS CREADAS
            Cursos curso1 = new Cursos { Nombre = "Programacion 1", RecuentoClases = 20, RecuentoEjercicios = 78 };
            Cursos curso2 = new Cursos { Nombre = "Precalculo", RecuentoClases = 15, RecuentoEjercicios = 98 };
            Cursos curso3 = new Cursos { Nombre = "Redes", RecuentoClases = 18, RecuentoEjercicios = 79 };

            // CURSOS AGREGADOS A PROFESOR
            profesor1.AgregarCurso(curso1);
            profesor2.AgregarCurso(curso2);
            profesor3.AgregarCurso(curso3);

            // AGREGAR ESTUDIANTES Y PROFESOR A UNA CLASE
            claseA.AgregarEstudiante(estudiante1);
            claseA.AgregarEstudiante(estudiante2);
            claseA.AgregarEstudiante(estudiante3);
            claseA.AgregarProfesor(profesor1);
            claseA.AgregarProfesor(profesor2);

            // AGREGAR ESTUDIANTES Y PROFESOR A UNA CLASE
            claseB.AgregarEstudiante(estudiante4);
            claseB.AgregarEstudiante(estudiante5);
            claseB.AgregarEstudiante(estudiante6);
            claseB.AgregarProfesor(profesor3);
            claseB.AgregarProfesor(profesor2);


            // IMPRIMIR LA INFORMACION  DE LAS CLASES, ESTUDIANTE Y PROFESOR
            claseA.ImprimirDatos();
            claseB.ImprimirDatos();

            Console.WriteLine("Presiona cualquier tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}