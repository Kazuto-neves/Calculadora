namespace Calculadora.Domain
{
    public class Valores
    {
        public long Valor1 { get; set; }
        public long Valor2 { get; set; }
        public Valores()
        {

        }
        public Valores(long valor1, long valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }
    }
}