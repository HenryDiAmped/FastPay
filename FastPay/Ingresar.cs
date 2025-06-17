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
    public partial class Ingresar : Form
    {
        ListaEnlazada _Lista2 = new ListaEnlazada();

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

        bool contrasenaVisible2 = false;
        private void Ingresar_Load(object sender, EventArgs e)
        {
            txtContraseña2.PasswordChar = '*';

            string rutaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro_Movimientos.txt");

            File.WriteAllText(rutaUsuarios, "");
        }

        private void btnVisualizarContra2_Click(object sender, EventArgs e)
        {
            contrasenaVisible2 = !contrasenaVisible2;

            if (contrasenaVisible2)
            {
                txtContraseña2.PasswordChar = '\0';
            }
            else
            {
                txtContraseña2.PasswordChar = '*';
            }
        }

        private void btnRetroceder2_Click(object sender, EventArgs e)
        {
            Login _login2 = new Login();
            _login2.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarUsuario(txtNumeroDNI2.Text, txtContraseña2.Text))
            {
                MessageBox.Show("Credenciales Ingresadas correctamente");
                Menu _Menu = new Menu();
                _Menu.Show();
                this.Hide();
            }
            else
                MessageBox.Show("No existe ninguna cuenta creada con esos campos");
        }

        public Ingresar()
        {
            InitializeComponent();
            _Lista2.CargarLista();
        }

        private void txtNumeroDNI2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool ValidarUsuario(string DNI, string contra)
        {
            NodoLista puntero = _Lista2.primero;
            while (puntero != null)
            {
                if (DNI == puntero.dato.NDNI.ToString() && puntero.dato.Contraseña.ToString() == contra)
                {
                    _Lista2.GuardarCuentaAbierta(puntero.dato.NCelular, puntero.dato.NDNI,
                                                 puntero.dato.NTarjeta, puntero.dato.CorreoElec,
                                                 puntero.dato.Contraseña, puntero.dato.Nombre,
                                                 puntero.dato.Dinero);
                    return true;
                }
                puntero = puntero.siguiente;
            }
            return false;
        }
    }
}
