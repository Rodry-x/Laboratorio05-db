using lab05.paths;

namespace lab05.metodos.invertirTexto
{
    public class InvertirTexto
    {
        public static void EjecutarInvertirTexto()
        {
            string rutaArchivo = Paths.ArchivoTxt;

            // Crear el archivo de texto si no existe y pedir al usuario que ingrese l�neas
            if (!File.Exists(rutaArchivo))
            {
                Console.Clear();
                Console.WriteLine("=========================================================================");
                Console.WriteLine("El archivo no existe. Escribe l�neas de texto (dejar vac�o para terminar):");
                Console.WriteLine("-------------------------------------------------------------------------");
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    string linea;
                    do
                    {
                        linea = Console.ReadLine();
                        if (!string.IsNullOrEmpty(linea))
                            sw.WriteLine(linea);
                    } while (!string.IsNullOrEmpty(linea));
                }
            }

            // Leer todas las l�neas y mostrarlas desde la �ltima hasta la primera
            string[] lineas = File.ReadAllLines(rutaArchivo);
            Console.Clear();
            Console.WriteLine("\n===============================================");
            Console.WriteLine("L�neas del archivo (de la �ltima a la primera):");
            Console.WriteLine("-----------------------------------------------");

            for (int i = lineas.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(lineas[i]);
            }
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}