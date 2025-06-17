using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPay
{
    public class NodoCola
    {
        public Producto producto { get; set; }
        public NodoCola siguiente { get; set; }
    }
}
