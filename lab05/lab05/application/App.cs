using System;
using lab05.metodos.comparacionDePilas;
using lab05.metodos.invertirTexto;
using lab05.metodos.verificarcapicua;

namespace lab05.application
{
    internal class App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("1) Multiplica Elementos");
            Console.WriteLine("2) Muestra sus líneas empezando por la ultima");
            Console.WriteLine("3) Verificando que el numero sea capicúa");
            Console.WriteLine("4) Verificando si las pilas son iguales");
            Console.WriteLine("5) Invertir el orden de las palabras");
            Console.WriteLine("=============================================");
            Console.Write("Elige una opción (1-5): ");

            string option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    //MultiplicaElementos.EjecutarMultiplicaElementos();
                    break;
                case "2":
                    //InvertirTexto.EjecutarInvertirTexto();
                    break;
                case "3":
                    VerificarNumeroCapicua.EjecutarVerificarCapicua();
                    break;
                case "4":
                    VerificarComparacionDePilas.EjecutarComparacionDePilas();
                    break;
                case "5":
                    InvertirTexto.EjecutarInvertirTexto();
                    break;
                default:
                    Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Opción no válida. Por favor, elige una opción entre 1 y 4.");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    break;
            }
        }
    }
}
