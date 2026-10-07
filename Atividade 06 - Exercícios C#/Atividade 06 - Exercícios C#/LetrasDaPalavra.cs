using System;

class LetrasDaPalavra
{
    public static void Executar()
    {
        string palavra;

        Console.Write("Digite uma palavra: ");
        palavra = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(palavra))
        {
            Console.Write("Valor inválido! Digite um palavra: ");
                palavra = Console.ReadLine();
        }

        palavra = palavra.Trim();

        Console.WriteLine();
        Console.WriteLine($"Letras da palavra \"{palavra}\":");

        foreach (char letra in palavra)
        {
            Console.WriteLine(letra);
        }
    }
}
