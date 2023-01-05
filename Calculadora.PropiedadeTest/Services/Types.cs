using Calculadora.Domain;
using FsCheck;

namespace Calculadora.PropiedadeTest.Services
{
    public class Types
    {
        //public static Arbitrary<decimal> DecimalPropTest() => Arb.Default.Decimal().Generator.Where(d => d <= -20 && d >= 20).ToArbitrary();

        public static Arbitrary<long> IntPropTest() => Arb.Default.Int64().Generator.Where(i => i>0 && i<=15).ToArbitrary();
        public static Arbitrary<Valores> ValoresPropTest() => IntPropTest().Generator.Select(i => new Valores(i, i)).ToArbitrary();
    }
}
