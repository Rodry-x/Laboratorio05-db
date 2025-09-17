using System;
using System.Collections.Generic;

namespace lab05.pila.comparaciondepila2
{
    internal class Pila1
    {
        private Stack<int> elementos = new();

        public void Push(int valor) => elementos.Push(valor);

        public int Pop() => elementos.Pop();

        public int Count => elementos.Count;

        public IEnumerable<int> GetElementos() => elementos;
    }
}
