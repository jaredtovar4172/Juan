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
    public partial class DialogBoxCaptura : Form
    {
        public DialogBoxCaptura()
        {
            InitializeComponent();
        }
        Alumno x = new Alumno();
        private void DialogBoxCaptura_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            x.Numero = int.Parse(textBox1.Text);
            x.Nombre = textBox2.Text;
            listBox1.Items.Add(x.Nombre + " " + x.Numero);
        }
    }
}
