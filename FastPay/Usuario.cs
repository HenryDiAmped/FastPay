using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPay
{
    public class Usuario
    {
        public int NCelular { get; set; }
        public int NDNI { get; set; }
        public string NTarjeta { get; set; }
        public string CorreoElec { get; set; }
        public int Contraseña { get; set; }
        public string Nombre { get; set; }
        public double Dinero { get; set; }

        public Usuario(int NCelular, int NDNI, string NTarjeta, string CorreoElec, int Contraseña, string Nombre)
        {
            this.NCelular = NCelular;
            this.NDNI = NDNI;
            this.NTarjeta = NTarjeta;
            this.CorreoElec = CorreoElec;
            this.Contraseña = Contraseña;
            this.Nombre = Nombre;

            Random rnd = new Random();
            this.Dinero = rnd.Next(500, 10001);
        }
        public Usuario(int NCelular, int NDNI, string NTarjeta, string CorreoElec, int Contraseña, string Nombre, double Dinero)
        {
            this.NCelular = NCelular;
            this.NDNI = NDNI;
            this.NTarjeta = NTarjeta;
            this.CorreoElec = CorreoElec;
            this.Contraseña = Contraseña;
            this.Nombre = Nombre;
            this.Dinero = Dinero;
        }
    }
}
