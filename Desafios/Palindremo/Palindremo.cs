public static class Palindromo
{
    public static bool EhPalindromo(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto)) return false;

        var textoLimpo = LimparTexto(texto);

        int inicio = 0;
        int fim = textoLimpo.Length - 1;

        while (inicio < fim)
        {
            if (textoLimpo[inicio] != textoLimpo[fim]) return false;
            inicio++;
            fim--;
        }

        return true;
    }

    private static string LimparTexto(string texto)
    {
        var resultado = "";

        foreach (char c in texto)
        {
            if (char.IsLetterOrDigit(c)) resultado += char.ToLower(c);
        }

        return resultado;
    }
}