using System.IO;
using Stekie;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtener las cookies de Chrome como un String
            string cookiesString = Chrome.cookies.GetString();

            // Escribir las cookies en un archivo de texto
            File.WriteAllText("cookies.txt", cookiesString);
        }
    }
}
