using lab05.nodo;

namespace lab05.pilaparaobtenerinicio
{
    class PilaParaObtenerInicio
    {
        private Nodo inicio;

        public PilaParaObtenerInicio()
        {
            inicio = null;
        }

        public Nodo getCima()
        {
            return inicio;
        }

        public void push(char valor)
        {
            Nodo nuevoNodo;
            nuevoNodo = new Nodo();
            nuevoNodo.dato = valor;
            nuevoNodo.siguiente = inicio;
            inicio = nuevoNodo;
        }
        public void pop()
        {
            Nodo aux = inicio;
            char valor = aux.dato;
            inicio = aux.siguiente;
            aux = null;
        }
    }
}
