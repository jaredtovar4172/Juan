using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           int b = int.Parse(textBox1.Text);
           Alumno[] arreglo = new Alumno [b];
           Alumno x = new Alumno();
           arreglo[i] = new Alumno();
           string cadena = x.CuentaNumeros(b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
