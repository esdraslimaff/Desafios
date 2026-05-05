using Desafios.Dominio;
using Desafios.Interfaces;

namespace Desafios.Apresentacao
{
    public class DesafioPalindromo : IDesafio
    {
        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("--- Desafio do Palíndromo ---");
            Console.Write("Digite um texto para testar: ");

            var texto = Console.ReadLine();

            var resultado = Palindromo.EhPalindromo(texto);

            Console.WriteLine($"\nO texto digitado é palíndromo? {resultado}");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
        }
    }
}
