using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_MetodoConCalculosMatematicos
{
    internal class Potencia
    {
        public double CalcularPotencia(int numero, int exponente) // numero = 2, exponenete = 5 // se crea un metodo con retorno y con parametros provenientes del main
        {
            int acumulador =1; // se crea este acumulador que nos servira para que el resultado de la multiplicacion se acumula tantas veces sea igual al exponente

            for (int i = 1; i <= exponente; i++) // se usa un for para repetir la cantidad de veces sea el exponenete la multiplicacion del mismo numero 
            {                                                       // vuelta 1                             // vuelta 2         // vuelta 3     //  vuelta 4            // vuelta 5            // vuelta 6
                acumulador *= numero; // acumulador = acumulador * numero --> acu = 1 * 2 --> 2 / acu = 2 / acu = 2 * 2 --> 4 / acu = 4 * 2 --> 8 / acu = 8 * 2 --> 16 / acu = 16 * 2 ----> 32 / ya esta fuera de rango
                // como lo dije, se usa este acumulador para guardar el resultado de la multiplicacion del mismo numero la cantidad de veces que sea el exponente
            }
            return acumulador; // se retorna el resultado final del acumulador
        }
    }
}
