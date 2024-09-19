namespace Retkon.Fractions;

public readonly struct Fraction
{
    public readonly int Numerator;
    public readonly int Denominator;

    public Fraction(int numerator, int denominator)
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

        this.Numerator = numerator;
        this.Denominator = denominator;
    }

    public readonly static Fraction Zero = new(0, 1);
    public readonly static Fraction One = new(1, 1);

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
        if (a.Numerator == 0)
            return b * -1;

        if (b.Numerator == 0)
            return a;

        return new Fraction(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        if (a.Numerator == 0 || a.Numerator == 0)
            return Zero;

        return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
    }

    public static Fraction operator +(Fraction a, int b)
    {
        return new Fraction(a.Numerator + b * a.Denominator, a.Denominator);
    }

    public static Fraction operator -(Fraction a, int b)
    {
        return new Fraction(a.Numerator - b * a.Denominator, a.Denominator);
    }

    public static Fraction operator *(Fraction a, int b)
    {
        return new Fraction(a.Numerator * b, a.Denominator);
    }

    public static Fraction operator /(Fraction a, int b)
    {
        return new Fraction(a.Numerator, a.Denominator * b);
    }
}
