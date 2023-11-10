using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_LDVP1
{
    public class Nodo
    {
        private int _datos;
        private Nodo _siguiente;
        public Nodo (int datos)
        {
            _datos = datos;
            _siguiente = null;
        }
        public Nodo(int valor, Nodo siguiente)
        {
            _datos = valor;
            _siguiente = siguiente;
        }
        public int Datos { get; }
        public Nodo Siguientes { get; set; }

    }
}
