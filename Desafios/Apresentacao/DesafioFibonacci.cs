using Desafios.Dominio;
using Desafios.Interfaces;

namespace Desafios.Apresentacao
{
    public class DesafioFibonacci : IDesafio
    {
        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("--- Desafio de Fibonacci ---");
            Console.Write("Digite a quantidade de elementos que deseja gerar: ");

            if (int.TryParse(Console.ReadLine(), out int quantidade))
            {
                var resultado = Fibonacci.Gerar(quantidade);

                Console.WriteLine($"\nResultado para X = {quantidade}: {string.Join(", ", resultado)}");
            }
            else
            {
                Console.WriteLine("\nValor inválido! Por favor, digite um número inteiro.");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
        }
    }
}
