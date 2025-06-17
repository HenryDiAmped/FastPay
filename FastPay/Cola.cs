using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FastPay
{
    public class Cola
    {
        public NodoCola primero;

        public NodoCola ultimo;

        public Cola()
        {
            primero = ultimo = null;
        }

        public void Encolar(Producto producto)
        {
            NodoCola aux = new NodoCola();
            aux.producto = producto;
            if (primero == null)
            {
                primero = aux;
                primero.siguiente = null;
                ultimo = aux;
            }
            else
            {
                ultimo.siguiente = aux;
                aux.siguiente = null;
                ultimo = aux;
            }
        }
        public void Mostrar(DataGridView DGV)
        {
            DGV.Rows.Clear();
            if (primero != null)
            {
                do
                {

                    DGV.Rows.Add(primero.producto.Nproducto, primero.producto.Precio);
                    primero = primero.siguiente;

                } while (primero != null);
            }
        }
    }
}
