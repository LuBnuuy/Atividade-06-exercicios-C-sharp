using System;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1 - Exibir números pares entre 0 e 100");
            Console.WriteLine("2 - Exibir números pares até um número informado");
            Console.WriteLine("3 - Exibir cada letra de uma palavra informada");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = -1;
            }

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    ParesAte100.Executar();
                    break;
                case 2:
                    ParesAteNumeroInformado.Executar();
                    break;
                case 3:
                    LetrasDaPalavra.Executar();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.Clear();
            }

        } while (opcao != 0);
    }
}