namespace Retkon.Fractions.Core.Tests.FractionOperations;

[TestClass]
public class FractionAddition
{
    [TestMethod]
    public void Fraction_Addition_ZeroPlusZero()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = Fraction.Zero;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Addition_ZeroPlusOne()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = new Fraction(1, 1);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(Fraction.One, result);
    }

    [TestMethod]
    public void Fraction_Addition_ZeroPlusMore()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = new Fraction(24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(b, result);
    }

    [TestMethod]
    public void Fraction_Addition_ZeroPlusMinusOne()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = Fraction.MinusOne;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(b, result);
    }

    [TestMethod]
    public void Fraction_Addition_ZeroPlusMinusMore()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = new Fraction(-24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(b, result);
    }

    [TestMethod]
    public void Fraction_Addition_OnePlusZero()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = Fraction.Zero;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(Fraction.One, result);
    }

    [TestMethod]
    public void Fraction_Addition_OnePlusOne()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = new Fraction(1, 1);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(2, 1), result);
    }

    [TestMethod]
    public void Fraction_Addition_OnePlusMore()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = new Fraction(24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(211, 187), result);
    }

    [TestMethod]
    public void Fraction_Addition_OnePlusMinusOne()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = Fraction.MinusOne;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Addition_OnePlusMinusMore()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = new Fraction(-24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(163, 187), result);
    }

    [TestMethod]
    public void Fraction_Addition_MinusOnePlusZero()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = Fraction.Zero;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(Fraction.MinusOne, result);
    }

    [TestMethod]
    public void Fraction_Addition_MinusOnePlusOne()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = new Fraction(1, 1);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Addition_MinusOnePlusMore()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = new Fraction(24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(-163, 187), result);
    }

    [TestMethod]
    public void Fraction_Addition_MinusOnePlusMinusOne()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = Fraction.MinusOne;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(-2, 1), result);
    }

    [TestMethod]
    public void Fraction_Addition_MinusOnePlusMinusMore()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = new Fraction(-24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(-211, 187), result);
    }

    [TestMethod]
    public void Fraction_Addition_MorePlusZero()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = Fraction.Zero;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(12, 179), result);
    }

    [TestMethod]
    public void Fraction_Addition_MorePlusOne()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = new Fraction(1, 1);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(191, 179), result);
    }

    [TestMethod]
    public void Fraction_Addition_MorePlusMore()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = new Fraction(24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(6540, 33473), result);
    }

    [TestMethod]
    public void Fraction_Addition_MorePlusMinusOne()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = Fraction.MinusOne;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(-167, 179), result);
    }

    [TestMethod]
    public void Fraction_Addition_MorePlusMinusMore()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = new Fraction(-24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(-2052, 33473), result);
    }

    [TestMethod]
    public void Fraction_Addition_MinusMorePlusZero()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = Fraction.Zero;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(-12, 179), result);
    }

    [TestMethod]
    public void Fraction_Addition_MinusMorePlusOne()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = new Fraction(1, 1);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(167, 179), result);
    }

    [TestMethod]
    public void Fraction_Addition_MinusMorePlusMore()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = new Fraction(24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(2052, 33473), result);
    }

    [TestMethod]
    public void Fraction_Addition_MinusMorePlusMinusOne()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = Fraction.MinusOne;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(-191, 179), result);
    }

    [TestMethod]
    public void Fraction_Addition_MinusMorePlusMinusMore()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = new Fraction(-24, 187);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new Fraction(-6540, 33473), result);
    }
}