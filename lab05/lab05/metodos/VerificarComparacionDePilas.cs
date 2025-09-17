using lab05.pila.comparaciondepila1;
using lab05.pila.comparaciondepila2;

namespace lab05.metodos.comparacionDePilas
{
    public class VerificarComparacionDePilas
    {
        public static void EjecutarComparacionDePilas()
        {
            var pila1 = new Pila1();
            var pila2 = new Pila2();

            // Llenar ambas pilas
            pila1.Push(1);
            pila1.Push(2);
            pila1.Push(3);

            pila2.Push(1);
            pila2.Push(2);
            pila2.Push(3);

            // Comparar si son iguales
            bool iguales = SonPilasIguales(pila1, pila2);
            Console.WriteLine(iguales ? "Las pilas son iguales." : "Las pilas son diferentes.");
        }

        static bool SonPilasIguales(Pila1 p1, Pila2 p2)
        {
            var elementos1 = p1.GetElementos();
            var elementos2 = p2.GetElementos();
            return System.Linq.Enumerable.SequenceEqual(elementos1, elementos2);
        }
    }
}
