
using lab05.nodo;

namespace lab05.pilaparaobtenerinicio
{
    internal class PilaParaObtenerInicio
    {
        private NodoInt inicio;

        public PilaParaObtenerInicio()
        {
            inicio = null;
        }

        public NodoInt getInicio()
        {
            return inicio;
        }

        public void push(int dato)
        {
            NodoInt nuevoNodo;
            nuevoNodo = new NodoInt();
            nuevoNodo.dato = dato;
            nuevoNodo.sgte = inicio;
            inicio = nuevoNodo;
        }
        public int pop()
        {
            NodoInt aux = inicio;
            int valor = aux.dato;
            inicio = inicio.sgte;
            aux = null;
            return valor;
        }
    }
}