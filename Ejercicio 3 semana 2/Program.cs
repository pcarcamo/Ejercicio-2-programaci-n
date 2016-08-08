using System;

class alfabeticamente
{
    static void Main(string[] args)
    {
        var Text = Console.ReadLine();
        var Letras = Text.ToCharArray();
        var Cantidad = Letras.Count;
        for (int I = 0; I < Letras.count; I ++)
        {
            Console.WriteLine(Letras[I]);
            if (I < Cantidad - 1)
                Console.WriteLine(Letras[I] + Letras[I + 1]);
        }
        if (I < Cantidad - 2)
            Console.WriteLine(Letras[I] + Letras[I + 1] + Letras[I + 2]);
    }
}


