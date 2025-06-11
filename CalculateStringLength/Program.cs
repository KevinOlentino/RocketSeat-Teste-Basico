Console.WriteLine("Escreva uma palavra ou uma frase:");
var wordOrPhrase = Console.ReadLine();

if (wordOrPhrase != null)
{
    var length = wordOrPhrase.Length;
    Console.WriteLine($"A palavra ou frase '{wordOrPhrase}' tem {length} caracteres.");
    return;
}

Console.WriteLine("Nenhuma entrada foi fornecida.");
