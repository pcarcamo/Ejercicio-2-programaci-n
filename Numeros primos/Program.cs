using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, numero, n;
            Console.WriteLine("Ingrese un numero");
            n = Convert.ToInt32(Console.ReadLine());
            for (numero = 1; nuemro < (n + 1); numero++)
            {
                if (n % numero == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine("El número no es Primo");
            }
            else
            {
                Console.WriteLine("El ´número es Primo");
            }
            Console.ReadLine();
        }
    }
}

      