using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAlumno
{
    class Lista
    {
        private Nodo head;
        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        public Lista()
        {
            head = null;
        }
        public void Agregar(Nodo n)
        {
            if (head == null)
            {
                head = n;
                return;
            }
            if (n.Numero < head.Numero)
            {
                n.Siguiente = head;
                head = n;
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (n.Numero < h.Siguiente.Numero)
                {
                    break;
                }
                h = h.Siguiente;
            }
            n.Siguiente = h.Siguiente;
            h.Siguiente = n;
        }
        public void AgregarMateria(NodoC n, int num)
        {
            if (head == null)
            {
                return;
            }
            if (head.Numero == num)
            {
                head.ListaMateria.Agregar(n);
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == num)
                {
                    h.Siguiente.ListaMateria.Agregar(n);
                    return;
                }
                h = h.Siguiente;
            }
            return;
        }
        public void Eliminar(int d)
        {
            if (head == null)
            {
                return;
            }
            if (head.Numero == d)
            {
                head = head.Siguiente;
                return;
            }
            Nodo h = Head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    break;
                }
                h = h.Siguiente;
            }
            if (h.Siguiente != null)
            {
                h.Siguiente = h.Siguiente.Siguiente;
            }
        }
        public void EliminarCalificacion(int d)
        {
            head.ListaMateria.Eliminar(d);
        }
        public void MostrarMaterias(ListView lista, int numeroAlumno)
        {
            Nodo h = head;
            lista.Items.Clear();
            while (h != null)
            {
                if (h.Numero == numeroAlumno)
                {
                    h.ListaMateria.Mostrar(lista);
                }
                h = h.Siguiente;
            }
        }
        public void Mostrar(ListView lista)
        {
            Nodo h = head;
            lista.Items.Clear();
            while (h != null)
            {
                ListViewItem caja = new ListViewItem(h.Numero.ToString());
                caja.SubItems.Add(h.Matricula);
                caja.SubItems.Add(h.Nombre + " " + h.ApellidoP + " " + h.ApellidoM);
                caja.SubItems.Add(h.Carrera);
                lista.Items.Add(caja);
                h = h.Siguiente;
            }
        }
        public bool Buscar(int d, ref Nodo b)
        {
            if (head == null)
            {
                return false;
            }
            if (head.Numero == d)
            {
                b = head;
                return true;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    b = h.Siguiente;
                    return true;
                }
                h = h.Siguiente;
            }
            return false;
        }
        public void Modificar(int d, string m, string n, string ap, string am, string c, ListaMateria lm)
        {
            if (head == null)
            {
                return;
            }
            if (head.Numero == d)
            {
                head.Matricula = m;
                head.Nombre = n;
                head.ApellidoP = ap;
                head.ApellidoM = am;
                head.Carrera = c;
                head.ListaMateria = lm;
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    h.Siguiente.Matricula = m;
                    h.Siguiente.Nombre = n;
                    h.Siguiente.ApellidoP = ap;
                    h.Siguiente.ApellidoM = am;
                    h.Siguiente.Carrera = c;
                    h.Siguiente.ListaMateria = lm;
                    return;
                }
                h = h.Siguiente;
            }
            return;
        }
        public void BuscarCalificacion(int d,string m, ref NodoC b)
        {
            head.ListaMateria.Buscar(d,m, ref b);
        }
        public void ModificarCal(int d, string m, double c)
        {
            head.ListaMateria.Modificar(d, m, c);
        }
        public override string ToString()
        {
            string listaTexto = "";
            Nodo h = head;
            while (h != null)
            {
                listaTexto += h.ToString() + " ";
                h = h.Siguiente;
            }
            return listaTexto;
        }
    }
}
