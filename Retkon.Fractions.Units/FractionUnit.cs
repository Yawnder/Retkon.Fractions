using System.Diagnostics.CodeAnalysis;

namespace Retkon.Fractions.Units;
public class FractionUnit<T> where T : notnull
{

    private readonly Fraction _fraction;
    private readonly Dictionary<T, short> _units;

    public long Numerator => this._fraction.Numerator;
    public long Denominator => this._fraction.Denominator;
    public IReadOnlyDictionary<T, short> Units => this._units;

    public FractionUnit(Fraction fraction, IEnumerable<T>? numeratorUnits = null, IEnumerable<T>? denominatorUnits = null)
    {
        this._fraction = fraction;
        numeratorUnits ??= [];
        denominatorUnits ??= [];

        this._units = (numeratorUnits ?? []).Select(e => new KeyValuePair<T, short>(e, 1))
            .Concat((denominatorUnits ?? []).Select(e => new KeyValuePair<T, short>(e, -1)))
            .GroupBy(e => e.Key)
            .Select(e => new KeyValuePair<T, short>(e.Key, (short)e.Sum(kvp => kvp.Value)))
            .Where(e => e.Value != 0)
            .ToDictionary();
    }

    public FractionUnit(Fraction fraction, Dictionary<T, short> units)
    {
        this._fraction = fraction;
        this._units = new Dictionary<T, short>(units);
    }

    private static void ValidateCompatibleUnits(FractionUnit<T> a, FractionUnit<T> b)
    {
        if (a._units.Count > 0 || b._units.Count > 0)
        {
            if (a._units.Count != b._units.Count)
                throw new InvalidOperationException("Different units.");

            foreach (var aUnitKvp in a._units)
            {
                if (!b._units.TryGetValue(aUnitKvp.Key, out var bUnitValue) || aUnitKvp.Value != bUnitValue)
                    throw new InvalidOperationException("Different units.");
            }
        }
    }

    private static Dictionary<T, short> SumUnits(Dictionary<T, short> aUnits, Dictionary<T, short> bUnits, bool isAdd)
    {
        var allUnits = aUnits.Keys.Union(bUnits.Keys);
        var units = new Dictionary<T, short>();
        var secondMultiplier = isAdd ? 1 : -1;

        foreach (var unit in allUnits)
        {
            aUnits.TryGetValue(unit, out var aUnitValue);
            bUnits.TryGetValue(unit, out var bUnitValue);
            var unitValue = aUnitValue + bUnitValue * secondMultiplier;

            if (unitValue != 0)
            {
                units[unit] = (short)unitValue;
            }
        }

        return units;
    }

    public override int GetHashCode()
    {
        return this._fraction.GetHashCode() * 13 + this._units.GetHashCode() * 23;
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        if (obj is not FractionUnit<T> that)
            return false;

        return this._fraction.Equals(that._fraction) && this._units.Count == that._units.Count && !this._units.Any(entry => !that._units.TryGetValue(entry.Key, out var thatValue) || thatValue != entry.Value);
    }

    public override string ToString()
    {
        return $"{{{this.Numerator} / {this.Denominator}, Units: {string.Join(", ", this.Units.Select(e => $"{e.Key} {e.Value}"))}}}";
    }

    public static FractionUnit<T> operator +(FractionUnit<T> a)
    {
        return a;
    }

    public static FractionUnit<T> operator -(FractionUnit<T> a)
    {
        return new FractionUnit<T>(-a._fraction, a._units);
    }

    public static FractionUnit<T> operator +(FractionUnit<T> a, FractionUnit<T> b)
    {
        ValidateCompatibleUnits(a, b);

        return new FractionUnit<T>(a._fraction + b._fraction, a._units.Count != 0 ? a._units : b._units);
    }

    public static FractionUnit<T> operator -(FractionUnit<T> a, FractionUnit<T> b)
    {
        ValidateCompatibleUnits(a, b);

        return new FractionUnit<T>(a._fraction - b._fraction, a._units.Count != 0 ? a._units : b._units);
    }

    public static FractionUnit<T> operator *(FractionUnit<T> a, FractionUnit<T> b)
    {
        var aUnits = a._units;
        var bUnits = b._units;

        var units = SumUnits(aUnits, bUnits, true);

        return new FractionUnit<T>(a._fraction * b._fraction, units);
    }

    public static FractionUnit<T> operator /(FractionUnit<T> a, FractionUnit<T> b)
    {
        var aUnits = a._units;
        var bUnits = b._units;

        var units = SumUnits(aUnits, bUnits, false);

        return new FractionUnit<T>(a._fraction / b._fraction, units);
    }

    //public static FractionUnit<T> operator %(FractionUnit<T> a, FractionUnit<T> b)
    //{
    //    if (b._units.Count != 0)
    //        throw new InvalidOperationException("Second term of a modulo operation can't have units.");

    //    return new FractionUnit<T>(a._fraction % b._fraction, a._units);
    //}

    public static bool operator ==(FractionUnit<T> a, FractionUnit<T> b)
    {
        return a.Equals(b);
    }

    public static bool operator !=(FractionUnit<T> a, FractionUnit<T> b)
    {
        return !a.Equals(b);
    }

    public static implicit operator FractionUnit<T>(Fraction fraction)
    {
        return new FractionUnit<T>(fraction, []);
    }

    public static implicit operator FractionUnit<T>(long value)
    {
        return new FractionUnit<T>(value, []);
    }

    public static implicit operator decimal(FractionUnit<T> value)
    {
        return (decimal)value.Numerator / (decimal)value.Denominator;
    }

}
