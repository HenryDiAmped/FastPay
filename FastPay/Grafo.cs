using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPay
{
    public class Grafo
    {
        int[,] mAdyacencia;
        int[] indegree;
        int nodos;
        public Grafo(int nodos)
        {
            this.nodos = nodos;
            mAdyacencia = new int[nodos, nodos];
            indegree = new int[nodos];
        }
        public void AdicionarArista(int nodoInicio, int nodoFinal)
        {
            mAdyacencia[nodoInicio, nodoFinal] = 1;
        }
        public int ObtenerAdyacencia(int fila, int columna)
        {
            return mAdyacencia[fila, columna];
        }
        public void MostrarAdyacencia()
        {
            int n = 0;
            int m = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (n = 0; n < nodos; n++)
            {
                Console.Write("\t{0}", n);
            }
            Console.WriteLine();
            for (n = 0; n < nodos; n++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(n);
                for (m = 0; m < nodos; m++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\t{0}", mAdyacencia[n, m]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
