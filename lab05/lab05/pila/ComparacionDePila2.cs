
namespace lab05.pila.comparaciondepila2
{
    internal class Pila2
    {
        private Stack<int> elementos = new();

        public void Push(int valor) => elementos.Push(valor);

        public IEnumerable<int> GetElementos() => elementos;
    }
}