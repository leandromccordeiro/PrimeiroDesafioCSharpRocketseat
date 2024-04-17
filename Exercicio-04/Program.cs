using System.Collections.Concurrent;

Console.WriteLine("Digite uma palavra/frase para contagem de caracteres: ");
string palavra = Console.ReadLine();
Console.WriteLine($"A palavra/frase digitada possui {palavra.Length} caracteres " +
    $"contando os espaços e {palavra.Replace(" ", "").Length} sem eles.");
