using Exercicio_03;

double valor1 = 0.0;
double valor2 = 0.0;

Console.WriteLine("Informe o primeiro valor ou digite 'push' para gerar um número aleatório: ");

if (Console.ReadLine().ToLower().Trim().Equals("push"))
{
    Random random = new Random();
    valor1 = random.Next(100);
    Console.WriteLine($"O primeiro valor gerado foi: {valor1}");
} else
{
    valor1 = double.Parse(Console.ReadLine());
}

Console.WriteLine("Informe o segundo valor ou digite 'push' para gerar um número aleatório: ");

if (Console.ReadLine().ToLower().Trim().Equals("push"))
{
    Random random = new Random();
    valor2 = random.Next(100);
    Console.WriteLine($"O segundo valor gerado foi: {valor2}");
} else
{
    valor2 = double.Parse(Console.ReadLine());
}


OperacaoAritmetica operacaoAritmetica = new OperacaoAritmetica(valor1, valor2);

Console.WriteLine($"A divisao dos valores é: {operacaoAritmetica.Divisao()}");
Console.WriteLine($"A soma dos valores é: {operacaoAritmetica.Soma()}");
Console.WriteLine($"A subtração dos valores é: {operacaoAritmetica.Subtracao()}");
Console.WriteLine($"A multiplicação dos valores é: {operacaoAritmetica.Multiplicacao()}");
Console.WriteLine($"A média dos valores é: {operacaoAritmetica.Media()}");