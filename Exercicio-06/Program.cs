Console.WriteLine("Digite a opção desejada da data atual: ");
Console.WriteLine($"" +
    $"Data completa --------------------------[1] " + 
    $"\nApenas a data no formato dd/mm/yyyy ----[2]" + 
    $"\nApenas a hora no formato de 24 horas ---[3]" +
    $"\nA data com o mês por extenso -----------[4]");

int resp = int.Parse(Console.ReadLine());
DateTime dateTime = DateTime.Now;

switch (resp)
{
    case 1:
        Console.WriteLine($"Data completa: {dateTime.ToLongDateString()} {dateTime.ToString("HH:mm:ss")}");
        break;
    case 2:
        Console.WriteLine($"Apenas a data no fomrato dd/mm/yyyy: {dateTime.ToString("dd/MM/yyyy")}");
        break;
    case 3:
        Console.WriteLine($"Apenas a hora no formato de 24 horas: {dateTime.ToString("HH:mm:ss")}");
        break;
    case 4:
        Console.WriteLine($"Data com o mês por extenso: {dateTime.ToString("dd/MMMM/yyyy")}");
        break;
    default:
        break;
           
}