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
    public partial class AppCompras : MaterialSkin.Controls.MaterialForm
    {
        public double precioTotal = 0;
        ListaEnlazada CargarInfoUsuarioAbierto2 = new ListaEnlazada();
        ListaEnlazada _Lista3 = new ListaEnlazada();
        Cola _cola = new Cola();
        public AppCompras()
        {
            InitializeComponent();
        }

        private void AppCompras_Load(object sender, EventArgs e)
        {
            CargarInfoUsuarioAbierto2.CargarCuentaAbierta();
            _Lista3.CargarLista();
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Amber700,
                MaterialSkin.Primary.Grey900, MaterialSkin.Primary.Blue800, MaterialSkin.Accent.Green700,
                MaterialSkin.TextShade.WHITE);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu _menu = new Menu();
            _menu.Show();
            this.Hide();
        }

        //Cofirmar Carrito
        private void rjButtom2_Click(object sender, EventArgs e)
        {
            rjButtom2.Enabled = false;
            CheckearCheckBoxes();
            _cola.Mostrar(dgvCarrito);
        }
        public void CheckearCheckBoxes()
        {
            //restaurante
            if (chbArrozPollo.Checked == true)
            {
                _cola.Encolar(new Producto(chbArrozPollo.Name.Substring(3), chbArrozPollo.Text.Substring(2)));
                precioTotal += double.Parse(chbArrozPollo.Text.Substring(2));
            }
            if (chbEnsaladaRusa.Checked == true)
            {
                _cola.Encolar(new Producto(chbEnsaladaRusa.Name.Substring(3), chbEnsaladaRusa.Text.Substring(2)));
                precioTotal += double.Parse(chbEnsaladaRusa.Text.Substring(2));
            }
            if (chbAjiPollo.Checked == true)
            {
                _cola.Encolar(new Producto(chbAjiPollo.Name.Substring(3), chbAjiPollo.Text.Substring(2)));
                precioTotal += double.Parse(chbAjiPollo.Text.Substring(2));
            }
            if (chbHigadoEncebollado.Checked == true)
            {
                _cola.Encolar(new Producto(chbHigadoEncebollado.Name.Substring(3), chbHigadoEncebollado.Text.Substring(2)));
                precioTotal += double.Parse(chbHigadoEncebollado.Text.Substring(2));
            }
            if (chbTallarinesRojo.Checked == true)
            {
                _cola.Encolar(new Producto(chbTallarinesRojo.Name.Substring(3), chbTallarinesRojo.Text.Substring(2)));
                precioTotal += double.Parse(chbTallarinesRojo.Text.Substring(2));
            }
            if (chbChaufa.Checked == true)
            {
                _cola.Encolar(new Producto(chbChaufa.Name.Substring(3), chbChaufa.Text.Substring(2)));
                precioTotal += double.Parse(chbChaufa.Text.Substring(2));
            }
            if (chbCeviche.Checked == true)
            {
                _cola.Encolar(new Producto(chbCeviche.Name.Substring(3), chbCeviche.Text.Substring(2)));
                precioTotal += double.Parse(chbCeviche.Text.Substring(2));
            }
            if (chbOlluquito.Checked == true)
            {
                _cola.Encolar(new Producto(chbOlluquito.Name.Substring(3), chbOlluquito.Text.Substring(2)));
                precioTotal += double.Parse(chbOlluquito.Text.Substring(2));
            }
            //Bebidas
            if (chbCocaCola.Checked == true)
            {
                _cola.Encolar(new Producto(chbCocaCola.Name.Substring(3), chbCocaCola.Text.Substring(2)));
                precioTotal += double.Parse(chbCocaCola.Text.Substring(2));
            }
            if (chbInkaKola.Checked == true)
            {
                _cola.Encolar(new Producto(chbInkaKola.Name.Substring(3), chbInkaKola.Text.Substring(2)));
                precioTotal += double.Parse(chbInkaKola.Text.Substring(2));
            }
            if (chbVino.Checked == true)
            {
                _cola.Encolar(new Producto(chbVino.Name.Substring(3), chbVino.Text.Substring(2)));
                precioTotal += double.Parse(chbVino.Text.Substring(2));
            }
            if (chbCoctel.Checked == true)
            {
                _cola.Encolar(new Producto(chbCoctel.Name.Substring(3), chbCoctel.Text.Substring(2)));
                precioTotal += double.Parse(chbCoctel.Text.Substring(2));
            }
            if (chbCerveza.Checked == true)
            {
                _cola.Encolar(new Producto(chbCerveza.Name.Substring(3), chbCerveza.Text.Substring(2)));
                precioTotal += double.Parse(chbCerveza.Text.Substring(2));
            }
            if (chbRon.Checked == true)
            {
                _cola.Encolar(new Producto(chbRon.Name.Substring(3), chbRon.Text.Substring(2)));
                precioTotal += double.Parse(chbRon.Text.Substring(2));
            }
            if (chbChicha.Checked == true)
            {
                _cola.Encolar(new Producto(chbChicha.Name.Substring(3), chbChicha.Text.Substring(2)));
                precioTotal += double.Parse(chbChicha.Text.Substring(2));
            }
            if (chbMaracuya.Checked == true)
            {
                _cola.Encolar(new Producto(chbMaracuya.Name.Substring(3), chbMaracuya.Text.Substring(2)));
                precioTotal += double.Parse(chbMaracuya.Text.Substring(2));
            }
            //mascotas
            if (chbComidaPerro.Checked == true)
            {
                _cola.Encolar(new Producto(chbComidaPerro.Name.Substring(3), chbComidaPerro.Text.Substring(2)));
                precioTotal += double.Parse(chbComidaPerro.Text.Substring(2));
            }
            if (chbComidaGato.Checked == true)
            {
                _cola.Encolar(new Producto(chbComidaGato.Name.Substring(3), chbComidaGato.Text.Substring(2)));
                precioTotal += double.Parse(chbComidaGato.Text.Substring(2));
            }
            if (chbRopa.Checked == true)
            {
                _cola.Encolar(new Producto(chbRopa.Name.Substring(3), chbRopa.Text.Substring(2)));
                precioTotal += double.Parse(chbRopa.Text.Substring(2));
            }
            if (chbCorrea.Checked == true)
            {
                _cola.Encolar(new Producto(chbCorrea.Name.Substring(3), chbCorrea.Text.Substring(2)));
                precioTotal += double.Parse(chbCorrea.Text.Substring(2));
            }
            if (chbShampoo.Checked == true)
            {
                _cola.Encolar(new Producto(chbShampoo.Name.Substring(3), chbShampoo.Text.Substring(2)));
                precioTotal += double.Parse(chbShampoo.Text.Substring(2));
            }
            if (chbCollar.Checked == true)
            {
                _cola.Encolar(new Producto(chbCollar.Name.Substring(3), chbCollar.Text.Substring(2)));
                precioTotal += double.Parse(chbCollar.Text.Substring(2));
            }
            if (chbPelota.Checked == true)
            {
                _cola.Encolar(new Producto(chbPelota.Name.Substring(3), chbPelota.Text.Substring(2)));
                precioTotal += double.Parse(chbPelota.Text.Substring(2));
            }
            if (chbHueso.Checked == true)
            {
                _cola.Encolar(new Producto(chbHueso.Name.Substring(3), chbHueso.Text.Substring(2)));
                precioTotal += double.Parse(chbHueso.Text.Substring(2));
            }
            //aparatos electricos
            if (chbAudifono.Checked == true)
            {
                _cola.Encolar(new Producto(chbAudifono.Name.Substring(3), chbAudifono.Text.Substring(2)));
                precioTotal += double.Parse(chbAudifono.Text.Substring(2));
            }
            if (chbLaptop.Checked == true)
            {
                _cola.Encolar(new Producto(chbLaptop.Name.Substring(3), chbLaptop.Text.Substring(2)));
                precioTotal += double.Parse(chbLaptop.Text.Substring(2));
            }
            if (chbLentesVR.Checked == true)
            {
                _cola.Encolar(new Producto(chbLentesVR.Name.Substring(3), chbLentesVR.Text.Substring(2)));
                precioTotal += double.Parse(chbLentesVR.Text.Substring(2));
            }
            if (chbMouse.Checked == true)
            {
                _cola.Encolar(new Producto(chbMouse.Name.Substring(3), chbMouse.Text.Substring(2)));
                precioTotal += double.Parse(chbMouse.Text.Substring(2));
            }
            if (chbMando.Checked == true)
            {
                _cola.Encolar(new Producto(chbMando.Name.Substring(3), chbMando.Text.Substring(2)));
                precioTotal += double.Parse(chbMando.Text.Substring(2));
            }
            if (chbCamara.Checked == true)
            {
                _cola.Encolar(new Producto(chbCamara.Name.Substring(3), chbCamara.Text.Substring(2)));
                precioTotal += double.Parse(chbCamara.Text.Substring(2));
            }
            if (chbCelular.Checked == true)
            {
                _cola.Encolar(new Producto(chbCelular.Name.Substring(3), chbCelular.Text.Substring(2)));
                precioTotal += double.Parse(chbCelular.Text.Substring(2));
            }
            if (chbTablet.Checked == true)
            {
                _cola.Encolar(new Producto(chbTablet.Name.Substring(3), chbTablet.Text.Substring(2)));
                precioTotal += double.Parse(chbTablet.Text.Substring(2));
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            btnPagar.Enabled = false;
            //guardar en las estructuras los pagos
            NodoLista puntero = _Lista3.primero;
            do
            {
                if (puntero.dato.NDNI.ToString() == CargarInfoUsuarioAbierto2.primero.dato.NDNI.ToString())
                {
                    puntero.dato.Dinero -= precioTotal;
                    CargarInfoUsuarioAbierto2.primero.dato.Dinero -= precioTotal;

                    //guardar los movimientos en el archivo de texto
                    string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro_Movimientos.txt");

                    using (StreamWriter sw = new StreamWriter(ruta, true))
                    {
                        sw.WriteLine("-" + precioTotal.ToString() + ":" + "CompraFastPay");
                    }
                }
                puntero = puntero.siguiente;
                
            } while (puntero != null);

            //Guardar Pagos en Los archivos de texto
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

            MessageBox.Show("Se realizó el pago con exito!!");
        }
    }
}
