using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_MetodoSinParametrosYconRetorno
{
    internal class Metodo
    {
        // los metodos por defecto si no le pones un modificador de acceso son private es por ello que es importante asignar un modificador de acceso a un metodo
        // vamos a usar el instanciar las clases en ves de usar el static en los metodos ya que nos servira mas para practicar POO

        public int ObtenerNumeroAleatorio()
        {
            Random numeroRandom = new Random();
            int aleatorio = numeroRandom.Next(1, 101);
            return aleatorio;

        }





    }
}
