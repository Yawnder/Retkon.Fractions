namespace Retkon.Fractions.Core.Tests.FractionOperations;

[TestClass]
public class FractionMultiplication
{
    [TestMethod]
    public void Fraction_Multiplication_ZeroMultipliedByZero()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = Fraction.Zero;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_ZeroMultipliedByOne()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = new Fraction(1, 1);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_ZeroMultipliedByMore()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = new Fraction(24, 187);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_ZeroMultipliedByMinusOne()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = Fraction.MinusOne;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_ZeroMultipliedByMinusMore()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = new Fraction(-24, 187);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_OneMultipliedByZero()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = Fraction.Zero;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_OneMultipliedByOne()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = new Fraction(1, 1);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.One, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_OneMultipliedByMore()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = new Fraction(24, 187);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(24, 187), result);
    }

    [TestMethod]
    public void Fraction_Multiplication_OneMultipliedByMinusOne()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = Fraction.MinusOne;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.MinusOne, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_OneMultipliedByMinusMore()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = new Fraction(-24, 187);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(-24, 187), result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MinusOneMultipliedByZero()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = Fraction.Zero;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MinusOneMultipliedByOne()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = new Fraction(1, 1);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.MinusOne, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MinusOneMultipliedByMore()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = new Fraction(24, 187);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(-24, 187), result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MinusOneMultipliedByMinusOne()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = Fraction.MinusOne;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.One, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MinusOneMultipliedByMinusMore()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = new Fraction(-24, 187);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(24, 187), result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MoreMultipliedByZero()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = Fraction.Zero;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MoreMultipliedByOne()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = new Fraction(1, 1);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(12, 179), result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MoreMultipliedByMore()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = new Fraction(24, 187);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(288, 33473), result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MoreMultipliedByMinusOne()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = Fraction.MinusOne;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(-12, 179), result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MoreMultipliedByMinusMore()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = new Fraction(-24, 187);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(-288, 33473), result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MinusMoreMultipliedByZero()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = Fraction.Zero;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MinusMoreMultipliedByOne()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = new Fraction(1, 1);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(-12, 179), result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MinusMoreMultipliedByMore()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = new Fraction(24, 187);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(-288, 33473), result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MinusMoreMultipliedByMinusOne()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = Fraction.MinusOne;

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(12, 179), result);
    }

    [TestMethod]
    public void Fraction_Multiplication_MinusMoreMultipliedByMinusMore()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = new Fraction(-24, 187);

        // Act
        var result = a * b;

        // Assert
        Assert.AreEqual(new Fraction(288, 33473), result);
    }
}