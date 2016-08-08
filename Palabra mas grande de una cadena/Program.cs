using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palabra_mas_grande_de_una_cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabraGrande = "";
            int palabra = 0;
            while (true)
            {
                Console.Write("Ingrese una oración ");
                palabraGrande = Console.ReadLine();
                if (palabraGrande == "")
                    break;
                if (palabra > palabraGrande.Length)
                    palabraGrande = palabra;
            }
            Console.WriteLine("palabra mas larga fue: {0}", palabraGrande);
            Console.ReadLine();
        }
    }
}



