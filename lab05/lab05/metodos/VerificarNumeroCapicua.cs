

namespace lab05.metodos.verificarcapicua
{
    public class VerificarNumeroCapicua
    {
        public static void EjecutarVerificarCapicua()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("| Verificar si un numero es capicúa |");
            Console.WriteLine("-------------------------------------");
            Console.Write("Ingresa un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            int original = numero;
            int invertido = 0;

            while (numero > 0)
            {
                int digito = numero % 10;
                invertido = invertido * 10 + digito;
                numero = numero / 10;
            }

            if (original == invertido)
                Console.WriteLine("\nEl número es capicúa.");
            else
                Console.WriteLine("\nEl número no es capicúa.");

            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}