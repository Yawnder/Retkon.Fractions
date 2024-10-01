#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Retkon.Fractions;
#pragma warning restore IDE0130 // Namespace does not match folder structure

public readonly struct Fraction
{
    public readonly static Fraction Zero = new(0, 1);
    public readonly static Fraction One = new(1, 1);
    public readonly static Fraction MinusOne = new(-1, 1);

    public readonly long Numerator;
    public readonly long Denominator;

    public Fraction(long numerator, long denominator, bool reduce = true)
    {
        switch (denominator)
        {
            case < 0:
                numerator *= -1;
                denominator *= -1;
                break;
            case 0:
                throw new DivideByZeroException($"{nameof(this.Denominator)} can't be 0.");
        }

        if (numerator == 0)
            denominator = 1;

        if (reduce)
        {
            (numerator, denominator) = ReduceCore(numerator, denominator);
        }

        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    public static Fraction operator +(Fraction a)
    {
        return a;
    }

    public static Fraction operator -(Fraction a)
    {
        return new Fraction(-a.Numerator, a.Denominator);
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        if (a.Numerator == 0)
            return b;

        if (b.Numerator == 0)
            return a;

        return new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        if (b.Numerator == 0)
            return a;

        if (a.Numerator == 0)
            return b * -1;

        return new Fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        if (a.Numerator == 0 || b.Numerator == 0)
            return Zero;

        return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
    }

    //public static Fraction operator %(Fraction a, Fraction b)
    //{
    //    return new Fraction((a.Numerator * b.Denominator) % (b.Numerator * a.Denominator), a.Denominator * b.Denominator);
    //}

    public Fraction Reduce()
    {
        var (numerator, denominator) = ReduceCore(this.Numerator, this.Denominator);
        return new Fraction(numerator, denominator);
    }

    private static (long, long) ReduceCore(long numerator, long denominator)
    {
        var isNegativeMultiplier = (numerator < 0) != (denominator < 0) ? -1 : 1;
        numerator = Math.Abs(numerator);
        denominator = Math.Abs(denominator);

        if (numerator == denominator)
        {
            return (isNegativeMultiplier, 0);
        }
        else if (numerator % denominator == 0)
        {
            return (numerator / denominator * isNegativeMultiplier, 1);
        }
        else if (denominator % numerator == 0)
        {
            return (isNegativeMultiplier, denominator / numerator);
        }
        else
        {
            var largestCommon = 1L;

            while (true)
            {
                var hasValue = false;
                var maxi = Math.Ceiling(Math.Min(Math.Sqrt(numerator), Math.Sqrt(denominator)));
                for (int i = 2; i <= maxi; i++)
                {
                    if (numerator % i == 0 && denominator % i == 0)
                    {
                        numerator /= i;
                        denominator /= i;
                        largestCommon *= i;
                        hasValue = true;
                        break;
                    }
                }
                if (hasValue)
                    continue;

                break;
            }

            return (numerator / largestCommon * isNegativeMultiplier, denominator / largestCommon);
        }
    }

    public override string ToString()
    {
        return $"{this.Numerator} / {this.Denominator}";
    }

    public static implicit operator Fraction(long value)
    {
        return new Fraction(value, 1);
    }

    public static implicit operator decimal(Fraction value)
    {
        return (decimal)value.Numerator / (decimal)value.Denominator;
    }

}
