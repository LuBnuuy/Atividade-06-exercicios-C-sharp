using System;

class ParesAte100
{
    public static void Executar()
    {
        Console.WriteLine("Números pares entre 0 e 100:");

        for (int i = 2; i < 100; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}