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
            if (numerator % denominator == 0)
            {
                this.Numerator = numerator / denominator;
                this.Denominator = 1;
            }
            else if (denominator % numerator == 0)
            {
                this.Numerator = 1;
                this.Denominator = denominator / numerator;
            }
            else
            {
                var largestCommon = 1L;
                for (long i = Math.Min(Math.Abs(numerator), Math.Abs(denominator)) - 1; i > 0; i--)
                {
                    if (numerator % i == 0 && denominator % i == 0)
                    {
                        largestCommon = i;
                        break;
                    }
                }

                this.Numerator = numerator / largestCommon;
                this.Denominator = denominator / largestCommon;
            }
        }
        else
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
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
        if (this.Numerator == this.Denominator)
        {
            return Fraction.One;
        }
        else if (this.Numerator % this.Denominator == 0)
        {
            return new Fraction(this.Numerator / this.Denominator, 1);
        }
        else if (this.Denominator % this.Numerator == 0)
        {
            return new Fraction(1, this.Denominator / this.Numerator);
        }
        else
        {
            var largestCommon = 1L;
            for (long i = (long)Math.Sqrt(Math.Min(Math.Abs(this.Numerator), Math.Abs(this.Denominator))) - 1; i > 0; i--)
            {
                if (this.Numerator % i == 0 && this.Denominator % i == 0)
                {
                    largestCommon = i;
                    break;
                }
            }

            if (largestCommon > 1)
                return new Fraction(this.Numerator / largestCommon, this.Denominator / largestCommon);
            else
                return this;
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

    public static implicit operator float(Fraction value)
    {
        return (float)value.Numerator / (float)value.Denominator;
    }

}
