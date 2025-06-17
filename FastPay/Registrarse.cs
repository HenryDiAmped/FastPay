using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FastPay
{
    public partial class Registrarse : Form
    {
        ListaEnlazada _Lista = new ListaEnlazada();

        public Registrarse()
        {
            InitializeComponent();
            _Lista.CargarLista();
        }
        bool contrasenaVisible = false;
        private void Registrarse_Load(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (ValidarCelular(txtNumeroCelular.Text) &&
                ValidarDNI(txtNumeroDNI.Text) &&
                ValidarCorreo(txtCorreoElec.Text) &&
                ValidarTarjeta(txtNumeroTarjeta.Text) &&
                ValidarContraseña(txtContraseña.Text) &&
                rbTerminos.Checked &&
                txtNombre.Text != "")
            {
                _Lista.InsertarF(new Usuario(int.Parse(txtNumeroCelular.Text),
                                             int.Parse(txtNumeroDNI.Text),
                                             txtNumeroTarjeta.Text,
                                             txtCorreoElec.Text,
                                             int.Parse(txtContraseña.Text),
                                             txtNombre.Text));
                MessageBox.Show("La creacion de la cuenta ha sido exitosa!!!");
                _Lista.GuardarListaEnArchivo();
                Login _login = new Login();
                _login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El registro no se concretó\nRecuerde aceptar los terminos y condiciones");
            }
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
        private bool ValidarCelular(string Celular)
        {
            bool aux = false;
            if (Celular.Length == 9)
            {
                NodoLista puntero = _Lista.primero;
                while (puntero != null)
                {
                    if (Celular != puntero.dato.NCelular.ToString())
                    {
                        aux = true;
                    }
                    else
                    {
                        MessageBox.Show("El número de celular ya está en uso");
                        return aux;
                    }
                    puntero = puntero.siguiente;
                }
            }
            else
            {
                MessageBox.Show("La extension de dígitos del celular no es correcta");
            }
            return aux;
        }
        private bool ValidarDNI(string DNI)
        {
            bool aux = false;
            if (DNI.Length == 8)
            {
                NodoLista puntero = _Lista.primero;
                while (puntero != null)
                {
                    if (DNI != puntero.dato.NDNI.ToString())
                    {
                        aux = true;
                    }
                    else
                    {
                        MessageBox.Show("El número de DNI ya está registrado");
                        aux = false;
                        return aux;
                    }
                    puntero = puntero.siguiente;
                }
            }
            else
            {
                MessageBox.Show("La extension de dígitos del DNI no es correcta");
            }
            return aux;
        }
        private bool ValidarCorreo(string correo)
        {
            bool auxil = false;
            string patron = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            bool aux = Regex.IsMatch(correo, patron);
            bool auxi = false;
            if (!aux)
            {
                MessageBox.Show("El correo no está escrito correctamente");
            }
            else
            {
                NodoLista puntero = _Lista.primero;
                while (puntero != null)
                {
                    if (correo != puntero.dato.CorreoElec.ToString())
                    {
                        auxi = true;
                    }
                    else
                    {
                        MessageBox.Show("El correo electrónico ya está en uso");
                        auxi = false;
                        break;
                    }
                    puntero = puntero.siguiente;
                }
            }
            if (aux && auxi)
            {
                auxil = true;
            }
            return auxil;
        }
        private bool ValidarTarjeta(string Tarjeta)
        {
            bool aux = false;
            if (Tarjeta.Length == 16)
            {
                NodoLista puntero = _Lista.primero;
                while (puntero != null)
                {
                    if (Tarjeta != puntero.dato.NTarjeta.ToString())
                    {
                        aux = true;
                    }
                    else
                    {
                        MessageBox.Show("El número de tarjeta ya está registrado");
                        aux = false;
                        return aux;
                    }
                    puntero = puntero.siguiente;
                }
            }
            else
            {
                MessageBox.Show("La extension de dígitos del numero de tarjeta no es correcta");
            }
            return aux;
        }
        private bool ValidarContraseña(string Contraseña)
        {
            bool aux = false;
            if (Contraseña.Length == 6)
            {
                aux = true;
            }
            else
            {
                MessageBox.Show("La extension de dígitos de la contraseña no es correcta");
            }
            return aux;
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            Login _login = new Login();
            _login.Show();
            this.Hide();
        }

        private void txtNumeroCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es una letra o un espacio o la tecla de borrar
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                // Si no es una letra, espacio o tecla de borrar, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void btnVisualizarContra_Click(object sender, EventArgs e)
        {
            contrasenaVisible = !contrasenaVisible;

            if (contrasenaVisible)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }
    }
}
