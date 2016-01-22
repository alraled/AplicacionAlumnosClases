using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAlumnosClases.datos
{
    public class Persona
    {
        private String _nombre;

        public String Nombre
        {
            set { _nombre = value.ToUpper(); }

            get { return _nombre; }
        }
        public int Edad { get; set; }

        public void Detalles()
        {
            Console.WriteLine("{0} {1}", Nombre, Edad);
        }
    }
}
