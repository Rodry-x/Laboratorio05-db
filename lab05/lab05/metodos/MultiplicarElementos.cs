using lab05.pilaparaobtenerinicio;

namespace lab05.metodos.multiplicarElementos

{
    public class MultiplicarElementos
    {
        public void EjecutarMultiplicarElementos()
        {
            PilaParaObtenerInicio pila = new PilaParaObtenerInicio();
            int n;
            int valor;

            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("| Multiplicar elementos de una pila |");
            Console.WriteLine("-------------------------------------");
            Console.Write("Cantidad de elementos : ");
            string? entrada = Console.ReadLine();
            n = !string.IsNullOrEmpty(entrada) ? int.Parse(entrada) : 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Elemento " + i + ":");
                entrada = Console.ReadLine();
                valor = !string.IsNullOrEmpty(entrada) ? int.Parse(entrada) : 0;
                pila.push(valor);
            }

            Console.WriteLine("\n-------------------------------");
            Console.Write("Multiplicar por: ");
            entrada = Console.ReadLine();
            int multiplicador = !string.IsNullOrEmpty(entrada) ? int.Parse(entrada) : 1;

            // Paso 1: Extraer elementos y multiplicar
            PilaParaObtenerInicio pilaAux = new PilaParaObtenerInicio();
            while (pila.getInicio() != null)
            {
                valor = pila.pop();
                int resultado = valor * multiplicador;
                pilaAux.push(resultado);
            }

            // Paso 2: Restaurar el orden original
            while (pilaAux.getInicio() != null)
            {
                valor = pilaAux.pop();
                pila.push(valor);
            }

            // Mostrar pila multiplicada
            while (pila.getInicio() != null)
            {
                valor = pila.pop();
                Console.WriteLine("Elemento multiplicado: " + valor);
            }
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}