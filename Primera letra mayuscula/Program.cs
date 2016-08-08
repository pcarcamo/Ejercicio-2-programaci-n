using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primera_letra_mayuscula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese palabra:");
            string palabra = Console.ReadLine();

            Console.WriteLine("El texto es: {0}",
              palabra);

            Console.WriteLine("En mayúsculas: {0}",
              palabra.ToUpper());


            Console.ReadLine();
        }
    }

}

