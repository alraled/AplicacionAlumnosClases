using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionAlumnosClases.datos;

namespace AplicacionAlumnosClases
{
    class Program
    {
        static void Main(string[] args)
        {
            var al = new Alumno()
            {
                Curso = "C#",
                Edad = 22,
                Nombre = "Luis",
                Nota = 8
            };
            //var al2=new Alumno("Luis",9,22);

            Console.WriteLine(al.GetNotaTexto());

            al.Detalles();

            Console.ReadLine();
        }
    }
}
