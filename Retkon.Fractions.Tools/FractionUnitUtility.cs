using Retkon.Fractions.Units;

namespace Retkon.Fractions.Tools;
public static class FractionUnitUtility
{

    public static FractionUnit<T> Create<T>(decimal value, Dictionary<T, short> units) where T : notnull
    {
        return new FractionUnit<T>(FractionUtility.Create(value), units);
    }

}
