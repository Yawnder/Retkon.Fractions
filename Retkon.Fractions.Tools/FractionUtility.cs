using System.Globalization;

namespace Retkon.Fractions.Tools;

public static class FractionUtility
{

    private const int maximumLength = 18;

    public static Fraction Create(decimal value)
    {
        if (value == 0)
            return Fraction.Zero;

        var isNegative = value < 0;
        value = Math.Abs(value);

        var denominator = 1L;

        var minimumMultiplier = (decimal)(int)-Math.Log10((double)value) - 1;

        if (Math.Abs(minimumMultiplier) > maximumLength)
            throw new ArgumentOutOfRangeException(nameof(value), "Value too large for a Fraction.");

        if (minimumMultiplier > maximumLength)
            throw new ArgumentOutOfRangeException(nameof(value), "Value too small for a Fraction.");

        if (minimumMultiplier > 0)
        {
            value *= (decimal)Math.Pow(10, (double)minimumMultiplier);
            denominator = (long)(denominator * Math.Pow(10, (double)minimumMultiplier));
        }
        else
        {
            minimumMultiplier = 0;
        }

        var valueParts = value.ToString("0.####################", CultureInfo.InvariantCulture).Split(".");

        if (value > 1)
        {
            minimumMultiplier += valueParts[0].Length;
        }

        if (valueParts.Length == 2)
        {
            var extraMultiplier = Math.Min(maximumLength - minimumMultiplier, valueParts[1].Length);
            value *= (decimal)Math.Pow(10, (double)extraMultiplier);
            denominator = (long)(denominator * Math.Pow(10, (double)extraMultiplier));
        }

        value *= isNegative ? -1 : 1;

        return new Fraction((long)value, denominator);
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

}
