using System;

class ParesAteNumeroInformado
{
    public static void Executar()
    {
        int numero;

        Console.Write("Digite um número inteiro positivo: ");

        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.Write("Valor inválido! Digite um número inteiro positivo: ");
        }

        Console.WriteLine($"Números pares entre 0 e {numero}:");

        if (numero <= 2)
        {
            Console.Write("Nenhum");
        }

        for (int i = 2; i < numero; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }
}