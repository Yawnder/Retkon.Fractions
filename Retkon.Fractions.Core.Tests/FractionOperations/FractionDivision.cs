namespace Retkon.Fractions.Core.Tests.FractionOperations;

[TestClass]
public class FractionDivision
{
    [TestMethod]
    public void Fraction_Division_ZeroDividedByZero()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = Fraction.Zero;

        // Act
        try
        {
            var result = a / b;
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (DivideByZeroException) { }
    }

    [TestMethod]
    public void Fraction_Division_ZeroDividedByOne()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = new Fraction(1, 1);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Division_ZeroDividedByMore()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = new Fraction(24, 187);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Division_ZeroDividedByMinusOne()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = Fraction.MinusOne;

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Division_ZeroDividedByMinusMore()
    {
        // Arrange
        var a = Fraction.Zero;
        var b = new Fraction(-24, 187);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(Fraction.Zero, result);
    }

    [TestMethod]
    public void Fraction_Division_OneDividedByZero()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = Fraction.Zero;

        // Act
        try
        {
            var result = a / b;
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (DivideByZeroException) { }
    }

    [TestMethod]
    public void Fraction_Division_OneDividedByOne()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = new Fraction(1, 1);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(Fraction.One, result);
    }

    [TestMethod]
    public void Fraction_Division_OneDividedByMore()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = new Fraction(24, 187);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(187, 24), result);
    }

    [TestMethod]
    public void Fraction_Division_OneDividedByMinusOne()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = Fraction.MinusOne;

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(Fraction.MinusOne, result);
    }

    [TestMethod]
    public void Fraction_Division_OneDividedByMinusMore()
    {
        // Arrange
        var a = new Fraction(1, 1);
        var b = new Fraction(-24, 187);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(-187, 24), result);
    }

    [TestMethod]
    public void Fraction_Division_MinusOneDividedByZero()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = Fraction.Zero;

        // Act
        try
        {
            var result = a / b;
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (DivideByZeroException) { }
    }

    [TestMethod]
    public void Fraction_Division_MinusOneDividedByOne()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = new Fraction(1, 1);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(Fraction.MinusOne, result);
    }

    [TestMethod]
    public void Fraction_Division_MinusOneDividedByMore()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = new Fraction(24, 187);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(-187, 24), result);
    }

    [TestMethod]
    public void Fraction_Division_MinusOneDividedByMinusOne()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = Fraction.MinusOne;

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(Fraction.One, result);
    }

    [TestMethod]
    public void Fraction_Division_MinusOneDividedByMinusMore()
    {
        // Arrange
        var a = Fraction.MinusOne;
        var b = new Fraction(-24, 187);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(187, 24), result);
    }

    [TestMethod]
    public void Fraction_Division_MoreDividedByZero()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = Fraction.Zero;

        // Act
        try
        {
            var result = a / b;
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (DivideByZeroException) { }
    }

    [TestMethod]
    public void Fraction_Division_MoreDividedByOne()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = new Fraction(1, 1);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(12, 179), result);
    }

    [TestMethod]
    public void Fraction_Division_MoreDividedByMore()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = new Fraction(24, 187);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(187, 358), result);
    }

    [TestMethod]
    public void Fraction_Division_MoreDividedByMinusOne()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = Fraction.MinusOne;

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(-12, 179), result);
    }

    [TestMethod]
    public void Fraction_Division_MoreDividedByMinusMore()
    {
        // Arrange
        var a = new Fraction(12, 179);
        var b = new Fraction(-24, 187);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(-187, 358), result);
    }

    [TestMethod]
    public void Fraction_Division_MinusMoreDividedByZero()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = Fraction.Zero;

        // Act
        try
        {
            var result = a / b;
            // Assert
            Assert.Fail("Shouldn't reach here.");
        }
        catch (DivideByZeroException) { }
    }

    [TestMethod]
    public void Fraction_Division_MinusMoreDividedByOne()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = new Fraction(1, 1);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(-12, 179), result);
    }

    [TestMethod]
    public void Fraction_Division_MinusMoreDividedByMore()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = new Fraction(24, 187);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(-187, 358), result);
    }

    [TestMethod]
    public void Fraction_Division_MinusMoreDividedByMinusOne()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = Fraction.MinusOne;

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(12, 179), result);
    }

    [TestMethod]
    public void Fraction_Division_MinusMoreDividedByMinusMore()
    {
        // Arrange
        var a = new Fraction(-12, 179);
        var b = new Fraction(-24, 187);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new Fraction(187, 358), result);
    }
}