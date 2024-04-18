using System.Numerics;
using System.Text.RegularExpressions;

namespace Exercicio_05
{
    public class Veiculo
    {
        public string Placa { get; set; }

        public Veiculo(string placa)
        {
            Placa = placa;
        }

        public bool ValidaPlaca()
        {
            if (Placa.Trim().Length != 7)
            {
                return false;
                //Console.WriteLine("A placa informada possui quantidade de caracteres diferente do padrão '7'.");
            }
            else if (int.TryParse(Placa.Substring(0, 1), out int result) || int.TryParse(Placa.Substring(1, 1), out int result1)
                || int.TryParse(Placa.Substring(2, 1), out int result2))
            {
                return false;
                //Console.WriteLine("Os 3 primeiros caracteres precisam ser representados somente por textos.");
            }
            else if (!int.TryParse(Placa.Substring(3), out int caractNum))
            {
                return false;
                //Console.WriteLine("Os 4 últimos caracteres precisam ser representados somente por numeros.");
            }
            else
            {
                return true;
            }
        }

    }
}
