
namespace lab05.pila.comparaciondepila1
{
    internal class Pila1
    {
        private Stack<int> elementos = new();

        public void Push(int valor) => elementos.Push(valor);

        public IEnumerable<int> GetElementos() => elementos;
    }
}