using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Retkon.Fractions.Tools;

public static class FractionUtility
{

    private const int maximumLength = 18;

    public static Func<Fraction, Fraction>? AfterCreateDefaultTransformation { get; set; }

    public static Fraction Create(float value)
    {
        if (value == 0)
            return Fraction.Zero;

        var isNegative = value < 0;
        value = Math.Abs(value);

        var denominator = 1L;

        var minimumMultiplier = (float)(int)-Math.Log10(value) - 1;

        if (Math.Abs(minimumMultiplier) > maximumLength)
            throw new ArgumentOutOfRangeException(nameof(value), "Value too large for a Fraction.");

        if (minimumMultiplier > maximumLength)
            throw new ArgumentOutOfRangeException(nameof(value), "Value too small for a Fraction.");

        if (minimumMultiplier > 0)
        {
            value *= (float)Math.Pow(10, minimumMultiplier);
            denominator = (long)(denominator * Math.Pow(10, minimumMultiplier));
        }
        else
        {
            minimumMultiplier = 0;
        }

        var valueParts = value.ToString("0.####################", CultureInfo.InvariantCulture).Split(".");
        if (valueParts.Length == 2)
        {
            var extraMultiplier = Math.Min(maximumLength - minimumMultiplier, valueParts[1].Length);
            value *= (float)Math.Pow(10, extraMultiplier);
            denominator = (long)(denominator * Math.Pow(10, extraMultiplier));
        }

        value *= isNegative ? -1 : 1;

        var newFraction = new Fraction((long)value, denominator);
        if (AfterCreateDefaultTransformation != null)
        {
            newFraction = AfterCreateDefaultTransformation(newFraction);
        }

        return newFraction;
    }

    public static List<Fraction> SameBase(params Fraction[] fractions)
    {
        var result = fractions.Select(e => new Fraction(e.Numerator, e.Denominator)).ToList();
        var lcdParts = result.Select(e => e.Denominator).Distinct().ToList();

        if (lcdParts.Count < 2)
            return result;

        result = result
            .Select(e =>
            {
                var multiple = lcdParts.Where(v => v != e.Denominator).Aggregate(1L, (v0, v) => v0 * v);
                return new Fraction(e.Numerator * multiple, e.Denominator * multiple, false);
            }).ToList();

        return result;
    }

    public static Fraction Round(Fraction fraction, Fraction increment, MidpointRounding midpointRounding = MidpointRounding.ToEven)
    {
        return RoundCore(fraction, increment, e => (long)Math.Round(e, midpointRounding));
    }

    public static Fraction Floor(Fraction fraction, Fraction increment)
    {
        return RoundCore(fraction, increment, e => (long)Math.Floor(e));
    }

    public static Fraction Ceiling(Fraction fraction, Fraction increment)
    {
        return RoundCore(fraction, increment, e => (long)Math.Ceiling(e));
    }

    private static Fraction RoundCore(Fraction fraction, Fraction increment, Func<decimal, long> roundingOperation)
    {
        if (increment == Fraction.Zero)
            throw new ArgumentException("Can't use zero increments.");

        var valueFraction = (decimal)fraction.Numerator / (decimal)fraction.Denominator;
        var valueIncrement = (decimal)increment.Numerator / (decimal)increment.Denominator;
        var value = roundingOperation(valueFraction / valueIncrement);

        return new Fraction(increment.Numerator * value, increment.Denominator);
    }

}
