using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnoAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        int t = 0;
        Alumno[] arreglo;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            t = int.Parse(txtCantidad.Text);
            arreglo = new Alumno[t];
            txtCantidad.Clear();
            grpBox1.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (i < t)
            {
                arreglo[i] = new Alumno();
                arreglo[i].Numero = txtNumero.Text;
                arreglo[i].Nombre = txtNombre.Text;
                txtNumero.Clear();
                txtNombre.Clear();
                txtNumero.Focus();
                i++;
            }
            else
            {
                for (int x = 0; x < t; x++)
                {
                    lbxLista.Items.Add(arreglo[x]);
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            grpBox1.Visible = true;
            txtCantidad.Clear();
            txtNumero.Clear();
            txtNombre.Clear();
            txtCantidad.Focus();
            lbxLista.Items.Clear();
            i = 0;
            t = 0;
        }
    }
}
