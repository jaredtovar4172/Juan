using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
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
            if (n.Dato < head.Dato)
            {
                n.Siguiente = head;
                head = n;
                return;
            }
            Nodo h = head;
            while (h.Siguiente != null)
            {
                if (n.Dato < h.Siguiente.Dato)
                {
                    break;
                }
                h = h.Siguiente;
            }
                n.Siguiente = h.Siguiente;
                h.Siguiente = n;
        }
        public void Eliminar (int d)
        {
            if (head == null)
            {
                return;
            }
            if (head.Dato == d)
            {
                head = head.Siguiente;
                return;
            }
            Nodo h = Head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Dato == d)
                {
                    break;
                }
                h = h.Siguiente;
            }
            if (h.Siguiente == null)
            {
                return;
            }
            h.Siguiente = h.Siguiente.Siguiente;
        }
        public bool Buscar (int d)
        {
            if (head == null)
            {
                return false;
            }
            if (head.Dato == d)
            {
                head = head.Siguiente;
                return true;
            }
            Nodo h = Head;
            while (h.Siguiente != null)
            {
                if (h.Siguiente.Dato == d)
                {
                    return true;
                }
                h = h.Siguiente;
            }
            return false;
        }
        public override string ToString()
        {
            string listaTexto = "";
            Nodo h = head;
            while (h != null)
            {
                listaTexto += h.Dato + " ";
                h = h.Siguiente;
            }
            return listaTexto; 
        }
    }
}
