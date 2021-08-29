using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlumnoAR
{
    class Alumno
    {
        string numero;
        string nombre;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string ToString()
        {
            return numero + " " + nombre;
        }
    }
}
