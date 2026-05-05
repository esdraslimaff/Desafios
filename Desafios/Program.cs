using Desafios.Apresentacao;
using Desafios.Interfaces;

while (true)
{
    Console.Clear();
    Console.WriteLine("=================================");
    Console.WriteLine("       MENU DE DESAFIOS          ");
    Console.WriteLine("=================================");
    Console.WriteLine("0 - Sair.");
    Console.WriteLine("1 - Desafio do Palíndromo.");
    Console.WriteLine("2 - Desafio do Fibonacci.");
    Console.WriteLine("3 - Desafio Normalizador de Texto");
    Console.WriteLine("=================================");
    Console.Write("Escolha uma opção: ");

    var opcao = Console.ReadLine();

    if (opcao == "0")
    {
        Console.WriteLine("Saindo...");
        break;
    }

    IDesafio? desafio = opcao switch
    {
        "1" => new DesafioPalindromo(),
        "2" => new DesafioFibonacci(),
        "3" => new DesafioNormalizadorTextual(),
        _ => null
    };

    if (desafio != null)
    {
        desafio.Executar();
    }
    else
    {
        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
        Console.ReadKey();
    }
}