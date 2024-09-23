namespace Retkon.Fractions.Core.Tests.FractionOperations;

[TestClass]
public class FractionSubstraction
{
    [TestMethod]
    public void Fraction_Substraction_ZeroMinusZero()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = Fraction.Zero;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Substraction_ZeroMinusOne()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = Fraction.One;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(Fraction.MinusOne, result);
    }

    [TestMethod]
    public void Fraction_Substraction_ZeroMinusMore()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = new Fraction(24, 187);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(-24, 187), result);
    }

    [TestMethod]
    public void Fraction_Substraction_ZeroMinusMinusOne()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = Fraction.MinusOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(Fraction.One, result);
    }

    [TestMethod]
    public void Fraction_Substraction_ZeroMinusMinusMore()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = new Fraction(-24, 187);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(24, 187), result);
    }

    [TestMethod]
    public void Fraction_Substraction_OneMinusZero()
    {
        // Arrange
        var a = Fraction.One;
        var b = Fraction.Zero;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(Fraction.One, result);
    }

    [TestMethod]
    public void Fraction_Substraction_OneMinusOne()
    {
        // Arrange
        var a = Fraction.One;
        var b = Fraction.One;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Substraction_OneMinusMore()
    {
        // Arrange
        var a = Fraction.One;
        var b = new Fraction(24, 187);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(163, 187), result);
    }

    [TestMethod]
    public void Fraction_Substraction_OneMinusMinusOne()
    {
        // Arrange
        var a = Fraction.One;
        var b = Fraction.MinusOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(2, 1), result);
    }

    [TestMethod]
    public void Fraction_Substraction_OneMinusMinusMore()
    {
        // Arrange
        var a = Fraction.One;
        var b = new Fraction(-24, 187);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(211, 187), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MinusOneMinusZero()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = Fraction.Zero;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(Fraction.MinusOne, result);
    }

    [TestMethod]
    public void Fraction_Substraction_MinusOneMinusOne()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = Fraction.One;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(-2, 1), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MinusOneMinusMore()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = new Fraction(24, 187);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(-211, 187), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MinusOneMinusMinusOne()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = Fraction.MinusOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Substraction_MinusOneMinusMinusMore()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = new Fraction(-24, 187);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(-163, 187), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MoreMinusZero()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = Fraction.Zero;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(12, 179), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MoreMinusOne()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = Fraction.One;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(-167, 179), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MoreMinusMore()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = new Fraction(24, 187);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(-2052, 33473), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MoreMinusMinusOne()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = Fraction.MinusOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(191, 179), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MoreMinusMinusMore()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = new Fraction(-24, 187);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(6540, 33473), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MinusMoreMinusZero()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = Fraction.Zero;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(-12, 179), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MinusMoreMinusOne()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = Fraction.One;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(-191, 179), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MinusMoreMinusMore()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = new Fraction(24, 187);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(-6540, 33473), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MinusMoreMinusMinusOne()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = Fraction.MinusOne;

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(167, 179), result);
    }

    [TestMethod]
    public void Fraction_Substraction_MinusMoreMinusMinusMore()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = new Fraction(-24, 187);

        // Act
        var result = a - b;

        // Assert
        Assert.AreEqual(new Fraction(2052, 33473), result);
    }
}