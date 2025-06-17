using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FastPay
{
    public partial class Transferir : Form
    {
        ListaEnlazada CargarInfoUsuarioAbierto2 = new ListaEnlazada();
        ListaEnlazada _Lista3 = new ListaEnlazada();
        public Transferir()
        {
            InitializeComponent();
        }

        private void Transferir_Load(object sender, EventArgs e)
        {
            CargarInfoUsuarioAbierto2.CargarCuentaAbierta();
            _Lista3.CargarLista();

            NodoLista puntero = _Lista3.primero;
            while (puntero != null)
            {
                if (puntero.dato.NCelular.ToString() != CargarInfoUsuarioAbierto2.primero.dato.NCelular.ToString())
                {
                    dgvUsuariosRecientes.Rows.Add(puntero.dato.Nombre, puntero.dato.NCelular);
                }
                puntero = puntero.siguiente;
            }
        }

        private void dgvUsuariosRecientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtiene la fila seleccionada
            DataGridViewRow row = dgvUsuariosRecientes.Rows[e.RowIndex];

            // Asigna los valores de las celdas a los TextBoxes
            tbNumeroTelefonico.Text = row.Cells["Column2"].Value.ToString();
        }

        private void btnConfirmarTransferencia_Click(object sender, EventArgs e)
        {
            bool encontro = false;
            NodoLista puntero = _Lista3.primero;
            while (puntero != null)
            {
                if (puntero.dato.NDNI.ToString() == CargarInfoUsuarioAbierto2.primero.dato.NDNI.ToString())
                {
                    puntero.dato.Dinero -= double.Parse(tbMonto.Text);
                    CargarInfoUsuarioAbierto2.primero.dato.Dinero -= double.Parse(tbMonto.Text);
                }
                if (puntero.dato.NCelular.ToString() == tbNumeroTelefonico.Text)
                {
                    puntero.dato.Dinero += double.Parse(tbMonto.Text);

                    string rutaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro_Movimientos.txt");

                    using (StreamWriter sw = new StreamWriter(rutaUsuarios, true))
                    {
                        sw.WriteLine("-" + tbMonto.Text + ":" + puntero.dato.Nombre);
                    }
                    encontro = true;
                }
                puntero = puntero.siguiente;
            }
            if (!encontro)
            {
                string rutaUsuarios2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro_Movimientos.txt");

                using (StreamWriter sw = new StreamWriter(rutaUsuarios2, true))
                {
                    sw.WriteLine("-" + tbMonto.Text + ":" + tbNumeroTelefonico.Text);
                }
            }

            btnRetroceder2.Enabled = true;
            btnSoloRetroceder.Enabled = false;

            tbNumeroTelefonico.Text = "";
            tbMonto.Text = "";
        }

        private void btnRetroceder2_Click(object sender, EventArgs e)
        {
            string rutaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro_de_usuarios.txt");
            File.WriteAllText(rutaUsuarios, "");

            using (StreamWriter sw = new StreamWriter(rutaUsuarios))
            {
                NodoLista puntero2 = _Lista3.primero;
                while (puntero2 != null)
                {
                    sw.WriteLine(puntero2.dato.NCelular.ToString() + ":" + puntero2.dato.NDNI.ToString() + ":" +
                                 puntero2.dato.NTarjeta + ":" + puntero2.dato.CorreoElec.ToLower() + ":" +
                                 puntero2.dato.Contraseña.ToString() + ":" + puntero2.dato.Nombre.ToLower() + ":" +
                                 puntero2.dato.Dinero.ToString());
                    puntero2 = puntero2.siguiente;
                }
            }

            string contenido = $"{CargarInfoUsuarioAbierto2.primero.dato.NCelular}:{CargarInfoUsuarioAbierto2.primero.dato.NDNI}:" +
                                $"{CargarInfoUsuarioAbierto2.primero.dato.NTarjeta}:{CargarInfoUsuarioAbierto2.primero.dato.CorreoElec}:" +
                                $"{CargarInfoUsuarioAbierto2.primero.dato.Contraseña}:{CargarInfoUsuarioAbierto2.primero.dato.Nombre}:" +
                                $"{CargarInfoUsuarioAbierto2.primero.dato.Dinero}";

            // Especifica la ruta completa al archivo de texto que deseas sobrescribir.
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro_CuentaAbierta.txt");

            // Sobrescribe el archivo de texto con el nuevo contenido.
            File.WriteAllText(rutaArchivo, contenido);


            Menu _Menu = new Menu();
            _Menu.Show();
            this.Hide();
        }

        private void btnSoloRetroceder_Click(object sender, EventArgs e)
        {
            Menu _Menu = new Menu();
            _Menu.Show();
            this.Hide();
        }

        int posY = 0, posX = 0;
        private void PnlArriba_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
