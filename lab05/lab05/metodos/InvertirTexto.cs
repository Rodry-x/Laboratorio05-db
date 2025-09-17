using lab05.pilaGenerica;

namespace lab05.metodos.invertirTexto
{
    internal class InvertirTexto
    {
        
        /// Texto con el orden de las palabras invertido
        public static string Invertir(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto;

            var palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var pila = new PilaGenerica<string>();

            foreach (var palabra in palabras)
                pila.Push(palabra);

            var resultado = new List<string>();
            while (!pila.IsEmpty)
                resultado.Add(pila.Pop());

            return string.Join(' ', resultado);
        }

        
        public static void EjecutarInvertirTexto()
        {
            Console.Write("Introduce un texto: ");
            string entrada = Console.ReadLine();
            string invertido = Invertir(entrada);
            Console.WriteLine($"Texto invertido: {invertido}");
        }
    }
}
