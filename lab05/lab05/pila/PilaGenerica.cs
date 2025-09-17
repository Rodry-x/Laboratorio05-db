
namespace lab05.pilaGenerica
{
    public class PilaGenerica<T>
    {
        private readonly Stack<T> _stack;

        public PilaGenerica()
        {
            _stack = new Stack<T>();
        }

        // Agrega un elemento a la pila (push)
        public void Push(T item)
        {
            _stack.Push(item);
        }

        // Elimina y retorna el elemento superior de la pila (pop)
        public T Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("La pila está vacía.");
            return _stack.Pop();
        }

        // Retorna el elemento superior sin eliminarlo (top)
        public T Top()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("La pila está vacía.");
            return _stack.Peek();
        }

        // Elimina todos los elementos de la pila (clear)
        public void Clear()
        {
            _stack.Clear();
        }

        // Propiedad para saber si la pila está vacía
        public bool IsEmpty => _stack.Count == 0;

        // Propiedad para obtener el número de elementos en la pila
        public int Count => _stack.Count;
    }
}