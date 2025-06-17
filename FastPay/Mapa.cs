using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastPay
{
    public partial class Mapa : Form
    {
        public static readonly Color[] colores = { Color.SkyBlue, Color.White };
        public static List<NodoGrafo> nodos;
        public static int[,] laberinto;
        public Grafo grafo;
        public static Dictionary<string, int> dic;
        List<int> ruta;
        public static int pos;

        public Mapa()
        {
            InitializeComponent();
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            nodos = new List<NodoGrafo>();
            btnCrearCamino.Enabled = false;
            timer1.Interval = 500;
        }
        public static void MostrarTabla(int[,] tabla)
        {
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                Console.WriteLine("{0} --> {1}\t{2}\t{3}", i, tabla[i, 0], tabla[i, 1], tabla[i, 2]);
            }
            Console.WriteLine();
        }
        private void CalcularMAdj()
        {
            int nodo = 0;
            int inicio = 0;
            int final = 35;
            int distancia = 0;
            int n = 0;
            int m = 0;
            int cantNodos = 36;
            grafo = new Grafo(36);
            Console.WriteLine("==============================================");
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if ((laberinto[i, j] == 1) && (laberinto[i + 1, j] == 1))
                    {
                        string nombre = j + "," + i;
                        int nodo1 = dic[nombre];
                        nombre = j + "," + (i + 1);
                        int nodo2 = dic[nombre];
                        grafo.AdicionarArista(nodo1, nodo2);
                    }
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((laberinto[i, j] == 1) && (laberinto[i, j + 1] == 1))
                    {
                        string nombre = j + "," + i;
                        int nodo1 = dic[nombre];
                        nombre = (j + 1) + "," + i;
                        int nodo2 = dic[nombre];
                        grafo.AdicionarArista(nodo1, nodo2);
                    }
                }
            }
            grafo.MostrarAdyacencia();
            Console.WriteLine("==============================================================");
            Console.WriteLine("inicio\t:\t{0}", inicio);
            Console.WriteLine("final\t:\t{0}", final);
            Console.WriteLine("==============================================================");
            Console.WriteLine();
            int[,] tabla;
            tabla = new int[cantNodos, 3];
            //0 visitado
            //1 distancia
            //2 previo
            for (n = 0; n < cantNodos; n++)
            {
                tabla[n, 0] = 0;
                tabla[n, 1] = int.MaxValue;
                tabla[n, 2] = 0;
            }
            tabla[inicio, 1] = 0;
            MostrarTabla(tabla);
            Console.WriteLine("==============================================================");
            for (distancia = 0; distancia < cantNodos; distancia++)
            {
                for (n = 0; n < cantNodos; n++)
                {
                    if ((tabla[n, 0] == 0) && (tabla[n, 1] == distancia))
                    {
                        tabla[n, 0] = 1;
                        for (m = 0; m < cantNodos; m++)
                        {
                            if (grafo.ObtenerAdyacencia(n, m) == 1)
                            {
                                if (tabla[m, 1] == int.MaxValue)
                                {
                                    tabla[m, 1] = distancia + 1;
                                    tabla[m, 2] = n;
                                }
                            }
                        }
                    }
                }
            }
            MostrarTabla(tabla);
            Console.WriteLine("==============================================================");
            //obtener la ruta
            ruta = new List<int>();
            nodo = final;
            while (nodo != inicio)
            {
                ruta.Add(nodo);
                nodo = tabla[nodo, 2];
            }
            ruta.Add(inicio);
            ruta.Reverse();
            foreach (int pos in ruta)
            {
                Console.Write("{0}\t", pos);
            }
            Console.WriteLine();
            Console.WriteLine("==============================================================");
            if (ruta.Count > 2)
            {
                timer1.Enabled = true;
                MessageBox.Show("Puede continuar con su compra!!, Dale a la felcha para continuar");
            }
            else
            {
                MessageBox.Show("Demasiado Trafico, intente más tarde");
                btnDibujar.Enabled = true;
                Menu _menu = new Menu();
                _menu.Show();
                this.Hide();
            }
        }
        private void MostrarLaberinto()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                Console.Write(i);
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("\t{0}", laberinto[j, i]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("==============================================");
        }
        private void DibujarLaberinto()
        {
            btnCrearCamino.Enabled = true;
            pos = 0;
            timer1.Enabled = false;
            panel1.Controls.Clear();
            nodos = new List<NodoGrafo>();
            laberinto = new int[6, 6];
            dic = new Dictionary<string, int>();
            int k = 0;
            int f0 = 20;
            int c0 = 20;
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int f1 = f0 + 64 * i;
                    int c1 = c0 + 64 * j;
                    int cl = rnd.Next(0, 2);
                    if (i == 0 && j == 0)
                        cl = 1;
                    if (i == 5 && j == 5)
                        cl = 1;
                    PictureBox picture = new PictureBox();
                    panel1.Controls.Add(picture);
                    picture.Width = 64;
                    picture.Height = 64;
                    picture.Location = new Point(f1, c1);
                    picture.BackColor = colores[cl];
                    picture.Name = "pic_" + i + "_" + j;
                    picture.Paint += picture_paint;
                    picture.MouseUp += (s, args) =>
                    {
                        if (args.Button == MouseButtons.Left)
                        {
                            picture_Click(s, args);
                        }
                    };
                    laberinto[i, j] = cl;
                    NodoGrafo nodo = new NodoGrafo();
                    nodo.nombre = i + "," + j;
                    nodo.dato = k;
                    nodo.fila = i;
                    nodo.columna = j;
                    nodos.Add(nodo);
                    dic[nodo.nombre] = k;
                    k = k + 1;
                }
            }
        }
        void picture_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            string nombre = picture.Name;
            int i = Convert.ToInt32(nombre.Split('_')[1]);
            int j = Convert.ToInt32(nombre.Split('_')[2]);
            if ((i == 0) && (j == 0))
                return;
            if ((i == 5) && (j == 5))
                return;
            if (picture.BackColor == Color.SkyBlue)
            {
                picture.BackColor = Color.White;
                laberinto[i, j] = 1;
            }
            else
            {
                picture.BackColor = Color.SkyBlue;
                laberinto[i, j] = 0;
            }
        }
        void picture_paint(object sender, PaintEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            string nombre = picture.Name;
            int i = Convert.ToInt32(nombre.Split('_')[1]);
            int j = Convert.ToInt32(nombre.Split('_')[2]);
            ControlPaint.DrawBorder(e.Graphics, picture.ClientRectangle, Color.Black,
            ButtonBorderStyle.Solid);
            if (i == 0 && j == 0)
            {
                e.Graphics.DrawEllipse(new Pen(Color.Red, 4f), picture.Size.Width / 2 - 10,
                picture.Size.Height / 2 - 10, picture.Size.Width / 4, picture.Size.Height / 4);
            }
            if (i == 5 && j == 5)
            {
                e.Graphics.DrawEllipse(new Pen(Color.Red, 4f), picture.Size.Width / 2 - 10,
                picture.Size.Height / 2 - 10, picture.Size.Width / 4, picture.Size.Height / 4);
            }
        }

        private void btnCrearCamino_Click(object sender, EventArgs e)
        {
            btnCrearCamino.Enabled = false;
            btnDibujar.Enabled = false;
            PonerObstaculos();
            MostrarLaberinto();
            CalcularMAdj();
            btnSeguir.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("{0}\t{1}", pos, ruta[pos]);

            int nodo = ruta[pos];
            int i = nodos[nodo].fila;
            int j = nodos[nodo].columna;
            string nombre = "pic_" + j + "_" + i;
            foreach (PictureBox picture in panel1.Controls)
            {
                if (picture.Name == nombre)
                {
                    picture.BackColor = Color.Violet;
                }
                //fila 0
                if (i == 0 && j == 1)
                {
                    int x = 85, y = 3;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 0 && j == 2)
                {
                    int x = 172, y = 3;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 0 && j == 3)
                {
                    int x = 258, y = 3;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 0 && j == 4)
                {
                    int x = 344, y = 3;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 0 && j == 5)
                {
                    int x = 427, y = 3;
                    AgregarPictureBoxConImagen2(x, y);
                }
                //fila 1
                else if (i == 1 && j == 0)
                {
                    int x = 3, y = 90;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 1 && j == 1)
                {
                    int x = 85, y = 90;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 1 && j == 2)
                {
                    int x = 172, y = 90;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 1 && j == 3)
                {
                    int x = 258, y = 90;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 1 && j == 4)
                {
                    int x = 344, y = 90;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 1 && j == 5)
                {
                    int x = 427, y = 90;
                    AgregarPictureBoxConImagen2(x, y);
                }
                //fila 2
                else if (i == 2 && j == 0)
                {
                    int x = 3, y = 174;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 2 && j == 1)
                {
                    int x = 85, y = 174;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 2 && j == 2)
                {
                    int x = 172, y = 174;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 2 && j == 3)
                {
                    int x = 258, y = 174;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 2 && j == 4)
                {
                    int x = 344, y = 174;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 2 && j == 5)
                {
                    int x = 427, y = 174;
                    AgregarPictureBoxConImagen2(x, y);
                }
                //fila 3
                else if (i == 3 && j == 0)
                {
                    int x = 3, y = 258;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 3 && j == 1)
                {
                    int x = 85, y = 258;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 3 && j == 2)
                {
                    int x = 172, y = 258;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 3 && j == 3)
                {
                    int x = 258, y = 258;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 3 && j == 4)
                {
                    int x = 344, y = 258;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 3 && j == 5)
                {
                    int x = 427, y = 258;
                    AgregarPictureBoxConImagen2(x, y);
                }
                //fila 4
                else if (i == 4 && j == 0)
                {
                    int x = 3, y = 340;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 4 && j == 1)
                {
                    int x = 85, y = 340;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 4 && j == 2)
                {
                    int x = 172, y = 340;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 4 && j == 3)
                {
                    int x = 258, y = 340;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 4 && j == 4)
                {
                    int x = 344, y = 340;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 4 && j == 5)
                {
                    int x = 427, y = 340;
                    AgregarPictureBoxConImagen2(x, y);
                }
                //fila 5
                else if (i == 5 && j == 0)
                {
                    int x = 3, y = 422;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 5 && j == 1)
                {
                    int x = 85, y = 422;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 5 && j == 2)
                {
                    int x = 172, y = 422;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 5 && j == 3)
                {
                    int x = 258, y = 422;
                    AgregarPictureBoxConImagen2(x, y);
                }
                else if (i == 5 && j == 4)
                {
                    int x = 344, y = 422;
                    AgregarPictureBoxConImagen2(x, y);
                }
            }
            pos = pos + 1;
            if (pos == ruta.Count)
            {
                timer1.Enabled = false;
                pos = 0;
                btnDibujar.Enabled = true;
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            DibujarLaberinto();
        }

        public void PonerObstaculos()
        {
            int i = 0;
            for (int m = 0; m < 6; m++)
            {
                for (int n = 0; n < 6; n++)
                {
                    if (laberinto[n, m] == 0)
                    {
                        //fila 0
                        if (n == 0 && m == 1)
                        {
                            int x = 85, y = 3;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 0 && m == 2)
                        {
                            int x = 172, y = 3;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 0 && m == 3)
                        {
                            int x = 258, y = 3;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 0 && m == 4)
                        {
                            int x = 344, y = 3;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 0 && m == 5)
                        {
                            int x = 427, y = 3;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        //fila 1
                        else if (n == 1 && m == 0)
                        {
                            int x = 3, y = 90;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 1 && m == 1)
                        {
                            int x = 85, y = 90;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 1 && m == 2)
                        {
                            int x = 172, y = 90;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 1 && m == 3)
                        {
                            int x = 258, y = 90;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 1 && m == 4)
                        {
                            int x = 344, y = 90;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 1 && m == 5)
                        {
                            int x = 427, y = 90;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        //fila 2
                        else if (n == 2 && m == 0)
                        {
                            int x = 3, y = 174;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 2 && m == 1)
                        {
                            int x = 85, y = 174;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 2 && m == 2)
                        {
                            int x = 172, y = 174;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 2 && m == 3)
                        {
                            int x = 258, y = 174;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 2 && m == 4)
                        {
                            int x = 344, y = 174;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 2 && m == 5)
                        {
                            int x = 427, y = 174;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        //fila 3
                        else if (n == 3 && m == 0)
                        {
                            int x = 3, y = 258;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 3 && m == 1)
                        {
                            int x = 85, y = 258;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 3 && m == 2)
                        {
                            int x = 172, y = 258;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 3 && m == 3)
                        {
                            int x = 258, y = 258;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 3 && m == 4)
                        {
                            int x = 344, y = 258;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 3 && m == 5)
                        {
                            int x = 427, y = 258;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        //fila 4
                        else if (n == 4 && m == 0)
                        {
                            int x = 3, y = 340;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 4 && m == 1)
                        {
                            int x = 85, y = 340;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 4 && m == 2)
                        {
                            int x = 172, y = 340;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 4 && m == 3)
                        {
                            int x = 258, y = 340;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 4 && m == 4)
                        {
                            int x = 344, y = 340;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 4 && m == 5)
                        {
                            int x = 427, y = 340;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        //fila 5
                        else if (n == 5 && m == 0)
                        {
                            int x = 3, y = 422;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 5 && m == 1)
                        {
                            int x = 85, y = 422;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 5 && m == 2)
                        {
                            int x = 172, y = 422;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 5 && m == 3)
                        {
                            int x = 258, y = 422;
                            AgregarPictureBoxConImagen(x, y);
                        }
                        else if (n == 5 && m == 4)
                        {
                            int x = 344, y = 422;
                            AgregarPictureBoxConImagen(x, y);
                        }
                    }
                }
                i++;
            }
        }
        private void AgregarPictureBoxConImagen(int x, int y)
        {
            // Creamos un nuevo PictureBox
            PictureBox pictureBox = new PictureBox();

            // Establecemos la posición y el tamaño del PictureBox
            pictureBox.Location = new Point(y, x - 10); // Cambia las coordenadas según tus necesidades
            pictureBox.Size = new Size(32, 38); // Cambia el tamaño según tus necesidades

            // Cargamos la imagen desde un archivo (ajusta la ruta según la ubicación de tu imagen)
            pictureBox.Image = Properties.Resources.autorojo_remove;

            // Establecemos el fondo transparente
            pictureBox.BackColor = Color.Transparent;

            // Establecemos el modo de visualización para ajustar la imagen al tamaño del PictureBox
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Añadimos el PictureBox al formulario
            panel2.Controls.Add(pictureBox);
        }
        private void AgregarPictureBoxConImagen2(int x, int y)
        {
            // Creamos un nuevo PictureBox
            PictureBox pictureBox = new PictureBox();

            // Establecemos la posición y el tamaño del PictureBox
            pictureBox.Location = new Point(x + 3, y + 3); // Cambia las coordenadas según tus necesidades
            pictureBox.Size = new Size(17, 19); // Cambia el tamaño según tus necesidades

            // Establecemos el fondo violeta
            pictureBox.BackColor = Color.Violet;

            // Añadimos el PictureBox al formulario
            panel2.Controls.Add(pictureBox);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu _menu = new Menu();
            _menu.Show();
            this.Hide();
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            AppCompras _appCompras = new AppCompras();
            _appCompras.Show();
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
