namespace Desafios.Dominio
{
    public static class Fibonacci
    {
        public static List<int> Gerar(int quantidade)
        {
            var resultado = new List<int>();

            if (quantidade <= 0) return resultado;
            if (quantidade >= 1) resultado.Add(0);
            if (quantidade >= 2) resultado.Add(1);

            for (int i = 2; i < quantidade; i++)
            {
                int proximo = resultado[i - 1] + resultado[i - 2];
                resultado.Add(proximo);
            }

            return resultado;
        }
    }
}
