namespace Desafios.Dominio
{
    public static class NormalizadorTextual
    {
        public static string Normalizar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            var resultado = "";
            int i = 0;

            while (i < texto.Length)
            {
                char atual = texto[i];

                if (atual == '?' || atual == '!')
                {
                    bool temInterrogacao = false;
                    bool temExclamacao = false;
                    while (i < texto.Length && (texto[i] == '?' || texto[i] == '!'))
                    {//oi???
                        if (texto[i] == '?') temInterrogacao = true;
                        if (texto[i] == '!') temExclamacao = true;
                        i++;
                    }

                    if (temInterrogacao && temExclamacao) resultado += "?!";
                    else if (temInterrogacao) resultado += "?";
                    else resultado += "!";

                    continue;
                }

                resultado += atual;
                i++;
            }

            return resultado;
        }
    }
}
