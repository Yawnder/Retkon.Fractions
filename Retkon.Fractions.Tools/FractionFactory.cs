using System.Globalization;

namespace Retkon.Fractions.Tools;

public static class FractionFactory
{

    private const int maximumLength = 18;

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

        return new Fraction((long)value, denominator);
    }


}
