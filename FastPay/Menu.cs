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
    public partial class Menu : Form
    {   
        ListaEnlazada CargarInfoUsuarioAbierto = new ListaEnlazada();

        public Menu()
        {
            InitializeComponent();
        } 

        private void Menu_Load(object sender, EventArgs e)
        {
            CargarInfoUsuarioAbierto.CargarCuentaAbierta();
            lbNombre.Text += CargarInfoUsuarioAbierto.primero.dato.Nombre.ToUpper();
            lbDinero.Text = CargarInfoUsuarioAbierto.primero.dato.Dinero.ToString();
            MostrarMovimientos();
        }

        int posY = 0, posX = 0;

        private void btnComprarProducto_Click(object sender, EventArgs e)
        {
            Mapa _mapa = new Mapa();
            _mapa.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            Login _login = new Login();
            _login.Show();
            this.Hide();
        }

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

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Transferir _transferir = new Transferir();
            _transferir.Show();
            this.Hide();
        }

        public void MostrarMovimientos()
        {
            string rutaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro_Movimientos.txt");

            using (StreamReader sr = new StreamReader(rutaUsuarios))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] partes = linea.Split(':');
                    string Monto = partes[0];
                    string Nombre = partes[1];
                    dgvMovimientos.Rows.Add(Nombre, Monto);
                }
            }
        }
    }
}
