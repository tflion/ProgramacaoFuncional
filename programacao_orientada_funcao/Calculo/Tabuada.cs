using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo
{
    class Tabuada
    {
        public static void Calcular(int numero)
        {
            Console.WriteLine("                                                  * Tabuada do número " + numero + " *");
            Console.WriteLine("");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("                                                        " + numero + " x " + i + " = " + (numero * i));
            }
            Console.WriteLine("");
            Console.WriteLine("                                         Pressione 'ENTER' para retornar ao menu. ");
            Console.ReadLine();
        }

    }
}
