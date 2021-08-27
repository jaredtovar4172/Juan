using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    class Alumno
    {
        string nombre;
        int numero;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string CuentaNumeros(int cantidad)
        {
            DialogBoxCaptura captura = new DialogBoxCaptura();
            for (int i = 1; i <= cantidad; i++)
            {
                if (captura.ShowDialog() == DialogResult.OK)
                {
                }
                
            }
            return ("Numero: " + nombre + "\n" + "nombre" + numero);

        }
    }
}