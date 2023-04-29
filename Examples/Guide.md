# Guia de uso basico
En esta guia aprenderemos como usar Stekie de una forma simple en C#.

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

# Diferentes metodos
Ahora veremos los diferentes metodos para obtener las cookies de los diversos navegadores aceptados

Chrome.cookies
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
```
