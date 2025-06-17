using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPay
{
    public class Producto
    {
        public string Nproducto { get; set; }
        public string Precio { get; set; }

        public Producto(string Nproducto, string Precio)
        {
            this.Nproducto = Nproducto;
            this.Precio = Precio;
        }
    }
}
