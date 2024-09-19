namespace Retkon.Fractions.Tests;

[TestClass]
public class FractionAddition
{
    [TestMethod]
    public void Fraction_Addition_Fraction_ZeroPlusZero()
    {
        // Arrange
        var a = new Fraction(0, 1);
        var b = new Fraction(0, 1);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Addition_Fraction_ZeroPlusOne()
    {
        // Arrange
        var a = new Fraction(0, 1);
        var b = new Fraction(1, 1);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(Fraction.One, result);
    }

    [TestMethod]
    public void Fraction_Addition_Fraction_ZeroPlusMore()
    {
        // Arrange
        var a = new Fraction(0, 1);
        var b = new Fraction(24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(b, result);
    }

    [TestMethod]
    public void Fraction_Addition_Fraction_ZeroPlusMinusOne()
    {
        // Arrange
        var a = new Fraction(0, 1);
        var b = new Fraction(-1, 1);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(b, result);
    }

    [TestMethod]
    public void Fraction_Addition_Fraction_ZeroPlusMinusMore()
    {
        // Arrange
        var a = new Fraction(0, 1);
        var b = new Fraction(-24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(b, result);
    }

    [TestMethod]
    public void Fraction_Addition_Fraction_OnePlusZero()
    {
        // Arrange
        var b = new Fraction(0, 1);
        var a = new Fraction(1, 1);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(Fraction.One, result);
    }

    [TestMethod]
    public void Fraction_Addition_Fraction_MorePlusZero()
    {
        // Arrange
        var b = new Fraction(0, 1);
        var a = new Fraction(24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(a, result);
    }

}