using Calculadora.Domain;
using Calculadora.PropiedadeTest.Services;
using FsCheck;
using FsCheck.Xunit;
using static System.Math;

namespace Calculadora.PropiedadeTest
{
    public class CalculadoraPropTest
    {
        [Property(Arbitrary = new[] { typeof(Types) })]
        public Property TestarSomaSeOResultadoDaSomaEigualAUmaPotenciaDe2(Valores valores)
        {
            var operador = new Operadores();
            var Result = operador.TipoOperador("Soma", valores);
            return (Result == (valores.Valor1 * 2)).ToProperty().Collect(valores);
        }

        [Property(Arbitrary = new[] { typeof(Types) })]
        public Property TestarMultiplicacaoSeOResultadoDaMultiplicacaoEoInvesoDaDivisao(Valores valores)
        {
            var operador = new Operadores();
            var Result = operador.TipoOperador("Mutiplica", valores);
            return (Result/valores.Valor2 == (valores.Valor1)).ToProperty().When(valores.Valor1 > 2 && valores.Valor1 <=100).Collect(valores.Valor1).Collect(valores.Valor2);
        }

        [Property(Arbitrary = new[] { typeof(Types) })]
        public Property TestarPotencia2SeOResultadoDaPotencia2EoInvesoDaRaiz(Valores valores)
        {
            var operador = new Operadores();
            var Result = operador.TipoOperador("Potencia2", valores);
            return ((long)Sqrt(Result) == valores.Valor1).ToProperty().When(valores.Valor1 > 1).Collect(valores.Valor1);
        }

        [Property(Arbitrary = new[] { typeof(Types) })]
        public Property TestarPotenciaYSeOResultadoDaPotenciaYFazendoLogPelaBaseEigualAoExpoente(Valores valores)
        {
            var operador = new Operadores();
            var Result = operador.TipoOperador("PotenciaY", valores);
            return ((long)Log(Result,valores.Valor1) == valores.Valor2).ToProperty().When(valores.Valor1 > 1).Collect(valores.Valor1).Collect(valores.Valor2);
        }

        [Property(Arbitrary = new[] { typeof(Types) })]
        public Property TestarSubitracaoSeOResultadoDaSubtracaoSomadoPeloSubtraendoEigualAminuendo(Valores valores)
        {
            var operador = new Operadores();
            var Result = operador.TipoOperador("Subtrai", valores);
            return ((Result + valores.Valor2) == valores.Valor1).ToProperty().When(valores.Valor1 > 1).Collect(valores.Valor1).Collect(valores.Valor2);
        }
    }
}