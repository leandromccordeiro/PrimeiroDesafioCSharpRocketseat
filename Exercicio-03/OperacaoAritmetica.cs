using System.Threading.Channels;

namespace Exercicio_03
{
    public class OperacaoAritmetica
    {
        public double Valor1 { get; private set; }
        public double Valor2 { get; private set; }
        public OperacaoAritmetica(double valor1, double valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;
        }

        public double Soma ()
        {
            return Valor1 + Valor2;
        }
        public double Subtracao()
        {
            return Valor1 - Valor2;
        }
        public double Multiplicacao()
        {
            return Valor1 * Valor2;
        }
        public double Divisao()
        {
            if (Valor2 == 0.0)
            {
                throw new ArgumentException("O segundo número precisa ser diferente de 0");
            }
            return Valor1 / Valor2;
        }
        public double Media()
        {
            return (Valor1 + Valor2) / (float) 2;
        }
    }
}
