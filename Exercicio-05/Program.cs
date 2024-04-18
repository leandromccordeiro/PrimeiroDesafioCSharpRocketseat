using Exercicio_05;

Console.WriteLine("Informe a placa do vículo:");
Veiculo veiculo = new Veiculo(Console.ReadLine());

bool verificador = veiculo.ValidaPlaca();

Console.WriteLine(verificador);
