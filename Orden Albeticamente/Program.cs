using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_Albeticamente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            char[] arregloCaracteres = new char[palabra.Length];
            Console.WriteLine("Palabra ingresada es : {0}", palabra);
            palabra.CopyTo(0, arregloCaracteres, 0, arregloCaracteres.Length);
            Array.Sort(arregloCaracteres);
            Console.WriteLine("El orden alfabeticamente es: ");
            for (int i = 0; i < arregloCaracteres.Length; i++)
                Console.Write(arregloCaracteres[i]);
            Console.ReadLine();

        }
    }
}
