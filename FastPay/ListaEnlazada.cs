using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FastPay
{
    public class ListaEnlazada
    {
        public NodoLista primero;

        public ListaEnlazada()
        {
            primero = null;
        }
        public void InsertarF(Usuario item)
        {
            NodoLista auxiliar = new NodoLista();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (primero == null)
            {
                primero = auxiliar;
            }
            else
            {
                NodoLista puntero;
                puntero = primero;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }
        }
        public void GuardarListaEnArchivo()
        {
            string rutaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro_de_usuarios.txt");

            using (StreamWriter sw = new StreamWriter(rutaUsuarios))
            {
                NodoLista puntero = primero;
                while (puntero != null)
                {
                    sw.WriteLine(puntero.dato.NCelular.ToString() + ":" + puntero.dato.NDNI.ToString() + ":" + 
                                 puntero.dato.NTarjeta + ":" + puntero.dato.CorreoElec.ToLower() + ":" + 
                                 puntero.dato.Contraseña.ToString() + ":" + puntero.dato.Nombre.ToLower() + ":" +
                                 puntero.dato.Dinero.ToString());
                    puntero = puntero.siguiente;
                }
            }
        }
        public void CargarLista()
        {
            string rutaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro_de_usuarios.txt");

            using (StreamReader sr = new StreamReader(rutaUsuarios))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] partes = linea.Split(':');

                    if (partes.Length == 7)
                    {
                        string NCelular = partes[0];
                        string NDNI = partes[1];
                        string NTarjeta = partes[2];
                        string CorreoElec = partes[3];
                        string Contraseña = partes[4];
                        string Nombre = partes[5];
                        string Dinero = partes[6];

                        // Puedes almacenar estos valores en tu lista enlazada
                        InsertarF(new Usuario(int.Parse(NCelular), int.Parse(NDNI), 
                                               NTarjeta.ToLower(), CorreoElec.ToLower(),
                                               int.Parse(Contraseña), Nombre.ToLower(),
                                               double.Parse(Dinero)));
                    }

                }
            }

        }
        public void GuardarCuentaAbierta(int NCelular, int NDNI, string NTarjeta, string CorreoElec, int Contraseña, string Nombre, double Dinero)
        {
            string contenido = $"{NCelular}:{NDNI}:{NTarjeta}:{CorreoElec}:{Contraseña}:{Nombre}:{Dinero}";

            // Especifica la ruta completa al archivo de texto que deseas sobrescribir.
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro_CuentaAbierta.txt");

            // Sobrescribe el archivo de texto con el nuevo contenido.
            File.WriteAllText(rutaArchivo, contenido);
        }

        public void CargarCuentaAbierta()
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "registro_CuentaAbierta.txt");

            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] partes = linea.Split(':');

                    if (partes.Length == 7)
                    {
                        string NCelular = partes[0];
                        string NDNI = partes[1];
                        string NTarjeta = partes[2];
                        string CorreoElec = partes[3];
                        string Contraseña = partes[4];
                        string Nombre = partes[5];
                        string Dinero = partes[6];

                        // Puedes almacenar estos valores en tu lista enlazada
                        InsertarF(new Usuario(int.Parse(NCelular), int.Parse(NDNI),
                                               NTarjeta.ToLower(), CorreoElec.ToLower(),
                                               int.Parse(Contraseña), Nombre.ToLower(),
                                               double.Parse(Dinero)));
                    }

                }
            }
        }
    }
}
