using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_MetodoConParametrosYconRetorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Calculando el area de un rectangulo*****");
            int baseRectangulo, altura; // declarando variables
            
            Console.Write("Ingrese la base del rectangulo: ");  // solicitando al usuario que ingrese un valor de la base
            do // Se usa un do-while para repetir hasta que el usuario ingrese un número entero válido.
            {
                try // esto es para validar si el numero ingresado se puede transformar 
                {
                    baseRectangulo = int.Parse(Console.ReadLine()); // aqui es donde se almacena el valor que el usuario ingresa por consola
                    break; // si el valor ingresado se puede convertir a numero entero entonces sale del bucle infinito con la ayuda del break
                }
                catch (FormatException) // si en caso el valor ingresado no se puede transformar entonces capturamos la excepcion con el catch
                {
                    Console.WriteLine("Valor Invalido, debe ingresar un numero entero positivo.."); // mandamos mensaje de error al usuario
                    Console.Write("Ingrese la base del rectangulo otra vez: "); // y le pedimos que ingrese denuevo
                }
            }
            while (true); // este bucle true no se rompera hasta que no se ejecute el break que es cuando el valor ingresado si se puede convertir a entero
            

            Console.Write("Ingrese la altura del rectangulo: "); // esto es lo mismo que ek bucle anterior pero para la variable altura
            do
            {
                try
                {
                    altura = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor Invalido, debe ingresar un numero entero positivo..");
                    Console.Write("Ingrese la altura del rectangulo otra vez: ");

                }
            }
            while (true);

            // instanciar la clase rectangulo para poder usar el metodo que contiene la clase y lo hacemos por medio de el objeto creado al instanciar la clase
            ClaseRentangulo rectangulo1 = new ClaseRentangulo();
            Console.WriteLine($"El area del triangulo es {rectangulo1.CalcularArea(baseRectangulo,altura)}");
            // en esta parte imprimimos el calculo del area llamado al metodo por medio del objeto creado.
        }
    }
}
