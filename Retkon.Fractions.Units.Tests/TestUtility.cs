using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retkon.Fractions.Units.Tests;
internal static class TestUtility
{

    public readonly static FractionUnit FractionUnitZero = new FractionUnit(Fraction.Zero, []);
    public readonly static FractionUnit FractionUnitOne = new FractionUnit(Fraction.One, []);
    public readonly static FractionUnit FractionUnitMinusOne = new FractionUnit(Fraction.MinusOne, []);

}
