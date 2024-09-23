﻿using Retkon.Fractions.Units;

namespace Retkon.Fractions.Tools;
public static class FractionUnitFactory
{

    public static FractionUnit Create(float value, Dictionary<string, short> units)
    {
        return new FractionUnit(FractionFactory.Create(value), units);
    }

    public static FractionUnit<T> Create<T>(float value, Dictionary<T, short> units) where T : notnull
    {
        return new FractionUnit<T>(FractionFactory.Create(value), units);
    }

}
