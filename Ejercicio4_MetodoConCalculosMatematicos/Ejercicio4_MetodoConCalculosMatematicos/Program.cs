using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_MetodoConCalculosMatematicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando la potencia de un numero"); // este es eo titulo del ejercicio
            
            Console.Write("Ingrese un numero: "); // se solicita al usuario ingresar un numero
            int numero = int.Parse(Console.ReadLine()); // aqui es donde se almacena el numero ingresado por el usuario

            Console.Write("Ingrese el exponente: "); // lo mismo que arriba
            int exponente = int.Parse(Console.ReadLine()); // lo mismo que arriba

            Potencia potencia1 = new Potencia(); // aqui se instancia la clase Potencia para podercrear un objeto de la clase Potencia con la cual podremos
            // tener acceso  poder utilizar el metodo

            Console.WriteLine($"La potencia de {numero} elevado a la {exponente} es {potencia1.CalcularPotencia(numero, exponente)}"); 
            // se imprime el resultado pero antes se llama al metodo con los parametros ingresados por el usuario, hace el calculo y retorna el resultado
        }
    }
}
