using System;
using Stekie;

namespace example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verifica si se encontraron las cookies de Chrome
            if (Chrome.cookies.GetBool())
            {
                Console.WriteLine("Cookies encontradas para Chrome");
            }
            else
            {
                Console.WriteLine("No se encontraron cookies para Chrome");
            }

            // Verifica si se encontraron las cookies de Opera
            if (Opera.cookies.GetBool())
            {
                Console.WriteLine("Cookies encontradas para Opera");
            }
            else
            {
                Console.WriteLine("No se encontraron cookies para Opera");
            }

            // Verifica si se encontraron las cookies de Edge
            if (Edge.cookies.GetBool())
            {
                Console.WriteLine("Cookies encontradas para Edge");
            }
            else
            {
                Console.WriteLine("No se encontraron cookies para Edge");
            }

            // Verifica si se encontraron las cookies de Brave
            if (Brave.cookies.GetBool())
            {
                Console.WriteLine("Cookies encontradas para Brave");
            }
            else
            {
                Console.WriteLine("No se encontraron cookies para Brave");
            }

            // Verifica si se encontraron las cookies de Firefox
            if (Firefox.cookies.GetBool())
            {
                Console.WriteLine("Cookies encontradas para Firefox");
            }
            else
            {
                Console.WriteLine("No se encontraron cookies para Firefox");
            }

            // Verifica si se encontraron las cookies de una ruta específica
            Browser.cookies.Path("Ruta/a/las/cookies"); // especifica la ruta de las cookies
            if (Browser.cookies.GetBool())
            {
                Console.WriteLine("Cookies encontradas para la ruta especificada");
            }
            else
            {
                Console.WriteLine("No se encontraron cookies en la ruta especificada");
            }

            Console.WriteLine("[Enter para continuar]");
            Console.ReadLine();
        }
    }
}
