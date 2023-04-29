# Guia de uso basico
En esta guia aprenderemos como usar Stekie de una forma simple en C#.
- [Chrome](https://github.com/Lierx/Stekie/edit/master/Examples/Guide.md#chromecookies) : Obtener las cookies de Chrome
- [Opera](https://github.com/Lierx/Stekie/edit/master/Examples/Guide.md#operacookies) : Obtener las cookies de Opera
- [Edge](https://github.com/Lierx/Stekie/edit/master/Examples/Guide.md#edgecookies) : Obtener las cookies de Edge
- [Brave](https://github.com/Lierx/Stekie/edit/master/Examples/Guide.md#bravecookies) : Obtener las cookies de Brave
- [Firefox](https://github.com/Lierx/Stekie/edit/master/Examples/Guide.md#firefoxcookies) : Obtener las cookies de Firefox
- [Browser](https://github.com/Lierx/Stekie/edit/master/Examples/Guide.md#browsercookies) : Obtener las cookies de una ruta especifica

Requisitos
-----------
- .NET Framework 4.8
- ( NuGet ) System.Data.SQLite

Comenzar
--------
Una vez tengas los archivos de Stekie en

```
TuProyecto\Cookies\
```

En el archivo .cs donde quieres utilizar las funciones debes agregar la directiva

```CSharp
Using Stekie
```

Asi que el codigo donde utilizaremos las funciones se veria tal que asi

```CSharp
using System;
using Stekie;

namespace myProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Codigo
        }
    }
}
```

Opera.cookies
---------
```CSharp
.GetString()
```
`Metodo Estatico` `String`
```CSharp
.GetList()
```
`Metodo Estatico` `List<Cookie>`

```CSharp
.GetBool()
```
`Metodo Estatico` `Boolean`

**Ejemplo**
```CSharp
using System;
using Stekie;

namespace myProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Opera.cookies.GetBool()) //Verifica si se encontraron las cookies de Opera
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
```

Edge.cookies
---------
```CSharp
.GetString()
```
`Metodo Estatico` `String`
```CSharp
.GetList()
```
`Metodo Estatico` `List<Cookie>`

```CSharp
.GetBool()
```
`Metodo Estatico` `Boolean`

**Ejemplo**
```CSharp
using System;
using Stekie;

namespace myProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Edge.cookies.GetBool()) //Verifica si se encontraron las cookies de Edge
            {
                Console.WriteLine("Cookies Encontradas:");
                Console.WriteLine(Edge.cookies.GetString()); //Si las encuentra las imprime en pantalla
            } else
            {
                Console.WriteLine("Cookies no encontradas."); //Si no las encuentra no hace nada
            }
            Console.WriteLine("[ Enter para continuar ]");
            Console.ReadLine();
        }
    }
}
```

Brave.cookies
---------
```CSharp
.GetString()
```
`Metodo Estatico` `String`
```CSharp
.GetList()
```
`Metodo Estatico` `List<Cookie>`

```CSharp
.GetBool()
```
`Metodo Estatico` `Boolean`

**Ejemplo**
```CSharp
using System;
using Stekie;

namespace myProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Brave.cookies.GetBool()) //Verifica si se encontraron las cookies de Brave
            {
                Console.WriteLine("Cookies Encontradas:");
                Console.WriteLine(Brave.cookies.GetString()); //Si las encuentra las imprime en pantalla
            } else
            {
                Console.WriteLine("Cookies no encontradas."); //Si no las encuentra no hace nada
            }
            Console.WriteLine("[ Enter para continuar ]");
            Console.ReadLine();
        }
    }
}
```

Firefox.cookies
---------
```CSharp
.GetString()
```
`Metodo Estatico` `String`
```CSharp
.GetList()
```
`Metodo Estatico` `List<Cookie>`

```CSharp
.GetBool()
```
`Metodo Estatico` `Boolean`

**Ejemplo**
```CSharp
using System;
using Stekie;

namespace myProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Firefox.cookies.GetBool()) //Verifica si se encontraron las cookies de Firefox
            {
                Console.WriteLine("Cookies Encontradas:");
                Console.WriteLine(Firefox.cookies.GetString()); //Si las encuentra las imprime en pantalla
            } else
            {
                Console.WriteLine("Cookies no encontradas."); //Si no las encuentra no hace nada
            }
            Console.WriteLine("[ Enter para continuar ]");
            Console.ReadLine();
        }
    }
}
```

Browser.cookies
---------
```CSharp
.path(string: pathtocookies)
```
`Metodo Estatico` `Vacio`
```CSharp
.GetString()
```
`Metodo Estatico` `String`
```CSharp
.GetList()
```
`Metodo Estatico` `List<Cookie>`

```CSharp
.GetBool()
```
`Metodo Estatico` `Boolean`

**Ejemplo**
```CSharp
using System;
using Stekie;

namespace myProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Browser.cookies.Path("Ruta/a/las/cookies"); //Especifica una ruta para la obtencion de cookies

            if (Browser.cookies.GetBool()) //Verifica si se encontraron las cookies en la ruta especificada
            {
                Console.WriteLine("Cookies Encontradas:");
                Console.WriteLine(Browser.cookies.GetString()); //Si las encuentra las imprime en pantalla
            }
            else
            {
                Console.WriteLine("Cookies no encontradas."); //Si no las encuentra no hace nada
            }
            Console.WriteLine("[ Enter para continuar ]");
            Console.ReadLine();
        }
    }
}
```
