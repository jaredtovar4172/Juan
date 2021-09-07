using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimple
{
    public partial class Form1 : Form
    {
        Lista miLista;
        public Form1()
        {
            InitializeComponent();
            miLista = new Lista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int d = int.Parse(txtDato.Text);
            Nodo n = new Nodo(d, null);
            miLista.Agregar(n);
            txtDato.Clear();
            txtDato.Focus();
            MessageBox.Show(miLista + "");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int d = int.Parse(txtDato.Text);
            miLista.Eliminar(d);
            txtDato.Clear();
            txtDato.Focus();
            MessageBox.Show(miLista + "");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int d = int.Parse(txtDato.Text);
            if (miLista.Buscar(d))
            {
                MessageBox.Show("Existe ");
            }
            else
            {
                MessageBox.Show("NO Existe ");
            }
            txtDato.Clear();
            txtDato.Focus();
        }
    }
}
