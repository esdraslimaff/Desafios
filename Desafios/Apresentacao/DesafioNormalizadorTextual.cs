using Desafios.Dominio;
using Desafios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios.Apresentacao
{
    public class DesafioNormalizadorTextual : IDesafio
    {
        public void Executar()
        {
            Console.Clear();
            Console.WriteLine("--- Desafio Normalizador de Texto ---");
            Console.WriteLine("Este desafio reduz sequências longas de pontuação (ex: 'Que legal!!!' vira 'Que legal!').");
            Console.Write("\nDigite um texto para normalizar: ");

            var texto = Console.ReadLine() ?? "";

            var resultado = NormalizadorTextual.Normalizar(texto);

            Console.WriteLine($"\nTexto Normalizado: {resultado}");

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
        }
    }
}
