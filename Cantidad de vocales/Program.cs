using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantidad_de_vocales
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int contador1 = 0, contador2 = 0, consonantes;
            Console.WriteLine("Escribe una oración");
            palabra = Console.ReadLine();
            for (int i = 0; i < palabra.Length; i++)
            {
                contador1++;
            }
            for (int i = 0; i < palabra.Length; i++)
            {
                if ((palabra[i] == 'a') || (palabra[i] == 'e') || (palabra[i] == 'i') || (palabra[i] == 'o') || (palabra[i] == 'u'))
                {
                    contador2++;
                }
            }
            consonantes = contador1 - contador2;
            Console.WriteLine("La oración  tiene:  " + contador2 + " vocales");
            Console.ReadLine();
        }
    }


}
    

