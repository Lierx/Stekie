using System;
using System.IO;
using Stekie;
using Stekie;

namespace CookiesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookies = Chrome.cookies.GetList();

            // Imprimir las cookies en la consola
            foreach (var cookie in cookies)
            {
                Console.WriteLine(cookie.ToString());
            }

            // Escribir las cookies en un archivo de texto
            string cookiesFilePath = "cookies.txt";
            using (StreamWriter writer = new StreamWriter(cookiesFilePath))
            {
                foreach (var cookie in cookies)
                {
                    writer.WriteLine(cookie.ToString());
                }
            }

            Console.WriteLine("Las cookies se han guardado en el archivo: " + cookiesFilePath);
            Console.ReadLine();
        }
    }
}
