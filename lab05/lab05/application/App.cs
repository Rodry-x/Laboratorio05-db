// Obteniendo los namespaces necesarios
using lab05.metodos.comparacionDePilas;
using lab05.metodos.invertirOrdenPalabras;
using lab05.metodos.invertirTexto;
using lab05.metodos.verificarcapicua;
using lab05.metodos.multiplicarElementos;

// Definiendo la clase principal de la aplicación
internal class App
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            // Haciendo un menu para seleccionar
            Console.WriteLine("=============================================");
            Console.WriteLine("|        ~~~ Laboratorio semana 05 ~~~      |");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1) Multiplica Elementos");
            Console.WriteLine("2) Muestra sus líneas empezando por la ultima");
            Console.WriteLine("3) Verificando que el numero sea capicúa");
            Console.WriteLine("4) Verificando si las pilas son iguales");
            Console.WriteLine("5) Invertir el orden de las palabras");
            Console.WriteLine("=============================================");
            Console.Write("Elige una opción (1-5): ");

            // Leer la opción del usuario
            string option = Console.ReadLine();

            // Ejecutar la opción seleccionada
            switch (option)
            {
                case "1":
                    new MultiplicarElementos().EjecutarMultiplicarElementos();
                    break;
                case "2":
                    InvertirTexto.EjecutarInvertirTexto();
                    break;
                case "3":
                    VerificarNumeroCapicua.EjecutarVerificarCapicua();
                    break;
                case "4":
                    VerificarComparacionDePilas.EjecutarComparacionDePilas();
                    break;
                case "5":
                    InvertirOrdenPalabras.EjecutarInvertirElOrdenPalabras();
                    break;
                default:
                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Opción no válida. Por favor, elige una opción entre 1 y 5.");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    break;
            }

            Console.Write("\n¿Deseas elegir otra opción? (s/n): ");
            string respuesta = Console.ReadLine();
            continuar = respuesta.Trim().ToLower() == "s";
            Console.Clear();
        }
    }
}