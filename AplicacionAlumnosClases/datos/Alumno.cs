using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionAlumnosClases.datos
{
    public class Alumno
    {

        private String _nombre;

        public String Nombre
        {
            set
            {
                _nombre = value.ToUpper();
                
            }

        get { return _nombre;}
    }
    
   

    public int Nota { set; get; }
    public int Edad { get; set; }
        
    public string Curso { get; set; }

        //public Alumno()
        //{
        //    Nombre = "";
        //    Nota = 0;
        //    Edad = 0;
        //}

        //public Alumno(String nombre, int nota, int edad)
        //{
        //    Nombre = nombre;
        //    Nota = nota;
        //    Edad = edad;
        //}

        public void ModificarNota(int cantidad)
        {
            Nota += cantidad;
        }

        public String GetNotaTexto()
        {
            if (Nota < 5)
                return "Suspenso";
            else if (Nota < 7)
                return "Aprobado";
            else if (Nota < 9)
                return "Notable";
            else
                return "Sobresaliente";
        }

    }

}

