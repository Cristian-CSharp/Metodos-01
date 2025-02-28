using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_MetodoVoidSinRetorno
{
    internal class Mensaje
    {
        public void MostrarMensaje(string mensaje) // se creo el metodo publico que recibe un parametro string pero no devuelve nada
        {
            Console.WriteLine(mensaje); // se imprime por consola el valor del mensaje ya que al ser un void no se retorna nada al ejercicio
        }
    }
}
