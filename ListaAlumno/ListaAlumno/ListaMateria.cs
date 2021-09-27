﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAlumno
{
    class ListaMateria
    {
        private NodoC head;
        public NodoC Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaMateria()
        {
            head = null;
        }
        public void Agregar(NodoC n)
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
            NodoC h = head;
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
            NodoC h = Head;
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
        public void Mostrar(ListView lista)
        {
            NodoC h = head;
            lista.Items.Clear();
            while (h != null)
            {
                ListViewItem caja = new ListViewItem(h.Numero.ToString());
                caja.SubItems.Add(h.Materia);
                caja.SubItems.Add(h.Calificacion.ToString());
                lista.Items.Add(caja);
                h = h.Siguiente;
            }
        }
        public bool Buscar(int d,string m, ref NodoC b)
        {
            if (head == null)
            {
                return false;
            }
            if (head.Numero == d)
            {
                if (head.Materia == m)
                {
                    b = head;
                    return true;
                }
            }
            NodoC h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    if (h.Siguiente.Materia == m)
                    {
                        b = h.Siguiente;
                        return true;
                    }
                }
                h = h.Siguiente;
            }
            return false;
        }
        public void Modificar(int d, string m, double c)
        {
            if (head == null)
            {
                return;
            }
            if (head.Numero == d)
            {
                if (head.Materia == m)
                {
                    head.Calificacion = c;
                    return;
                }
            }
            NodoC h = head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Numero == d)
                {
                    if (h.Siguiente.Materia == m)
                    {
                        h.Siguiente.Calificacion = c;
                        return;
                    }
                }
                h = h.Siguiente;
            }
            return;
        }

        public override string ToString()
        {
            string listaTexto = "";
            NodoC h = head;
            while (h != null)
            {
                listaTexto += h.ToString() + " ";
                h = h.Siguiente;
            }
            return listaTexto;
        }
    }
}
