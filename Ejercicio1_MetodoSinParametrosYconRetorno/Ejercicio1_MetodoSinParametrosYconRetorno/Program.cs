using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_MetodoSinParametrosYconRetorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodo metodoRandom = new Metodo();
            Console.WriteLine($"Numero aleatorio: {metodoRandom.ObtenerNumeroAleatorio()}");
        }
    }
}
