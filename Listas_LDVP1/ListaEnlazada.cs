using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_LDVP1
{
    public class ListaEnlazada
    {
        Nodo primero;
        //Nodo ultimo;

        public ListaEnlazada()
        {
            primero = null;
        }
        public bool estaVacia()
        {
            return primero != null ? true : false ;
        }
        public int Longitud()
        {
            int contador = 0;
            if (estaVacia())
            {
                return contador;
            }
            else
            {
                if (primero.Siguientes == null)
                {
                    return (contador + 1);
                }
                else 
                {
                    Nodo actual = primero;
                    while (actual.Siguientes == null)
                    {
                        contador++;
                        actual = actual.Siguientes;
                    }
                    return contador + 1;
                }
            }
        }   
    }
}
