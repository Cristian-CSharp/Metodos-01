using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_MetodoVoidSinRetorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensaje Mensaje1 = new Mensaje(); // se instancia la clase Mensaje creando un objeto el cual nos servira para poder llamar al metodo
            // osea para poder utilizar el metodo de la otra clase es necesario instanciar la clase donde esta el metodo y con ello llamar al metodo y usarlo

            //Mensaje1.MostrarMensaje("Hola, bienvenido a C#"); // este era una alternativa de solucion pero lo quize hacer mas dinamica con el usuario

            Console.Write("Ingrese un mensaje: "); // esta es la otra alternativa donde le solicito al usuario ingresar el  mensaje que quiera por consola
            Mensaje1.MostrarMensaje(Console.ReadLine()); // y esta parte imprime el mensaje que mando el usuario sin antes llamar al metodo mediante el objeto
            //creado al instanciar la clase, ademas no tenemos que usar un ConsoleWriteLine para imprimir ya que esa funcion lo hace le metodo void
        }
    }
}
