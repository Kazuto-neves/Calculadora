using static System.Math;

namespace Calculadora.Domain
{
    public class Operadores
    {
        public long TipoOperador(string operador, Valores calculadora)
        {
            long total = 0;
            if (operador.Equals("Soma")) total = Somar(calculadora);
            else if (operador.Equals("Subitrai")) total = Subtrair(calculadora);
            else if (operador.Equals("Mutiplica")) total = Mutiplicacao(calculadora);
            else if (operador.Equals("Divide")) total = Divisao(calculadora);
            else if (operador.Equals("Potencia2")) total = Potencia2(calculadora);
            else if (operador.Equals("PotenciaY")) total = PotenciaY(calculadora);
            else if (operador.Equals("Exp")) total = Exponencial(calculadora);
            else if (operador.Equals("Raiz")) total = Raiz(calculadora);
            else if (operador.Equals("Log")) total = Logaritimo(calculadora);
            else if (operador.Equals("Log10")) total = Logaritimo10(calculadora);
            return total;
        }
        internal long Somar(Valores calculadora) => calculadora.Valor1 + calculadora.Valor2;
        internal long Subtrair(Valores calculadora) => calculadora.Valor1 - calculadora.Valor2;
        internal long Mutiplicacao(Valores calculadora) => calculadora.Valor1 * calculadora.Valor2;
        internal long Divisao(Valores calculadora) => calculadora.Valor1 / calculadora.Valor2;
        internal long Potencia2(Valores calculadora) => (long)Pow(calculadora.Valor1, 2);
        internal long PotenciaY(Valores calculadora) => (long)Pow(calculadora.Valor1, calculadora.Valor2);
        internal long Exponencial(Valores calculadora) => (long)Exp(calculadora.Valor1);
        internal long Raiz(Valores calculadora) => (long)Sqrt(calculadora.Valor1);
        internal long Logaritimo(Valores calculadora) => (long)Log(calculadora.Valor1,calculadora.Valor2);
        internal long Logaritimo10(Valores calculadora) => (long)Log10(calculadora.Valor1);
    }
}
