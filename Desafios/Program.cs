// See https://aka.ms/new-console-template for more information

// Desafio do Palindromo

string texto1 = "Ovo";
string texto2 = "Roma me tem amor";
string texto3 = "O lobo ama o bolo";
string texto4 = "Não sou um palindromo";

Console.WriteLine("Desafio do Palindromo");
Console.WriteLine(texto1 + ": " + Palindromo.EhPalindromo(texto1));
Console.WriteLine(texto2 + ": " + Palindromo.EhPalindromo(texto2));
Console.WriteLine(texto3 + ": " + Palindromo.EhPalindromo(texto3)); 
Console.WriteLine(texto4 + ": " + Palindromo.EhPalindromo(texto4)); 
Console.WriteLine("-------------------------------------------------");