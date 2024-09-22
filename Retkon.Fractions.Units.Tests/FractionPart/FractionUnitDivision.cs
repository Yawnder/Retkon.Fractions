namespace Retkon.Fractions.Units.Tests.FractionPart;

[TestClass]
public class FractionUnitDivision
{
    [TestMethod]
    public void FractionUnit_Division_ZeroDividedByZero()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = TestUtility.FractionUnitZero;

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
    public void FractionUnit_Division_ZeroDividedByOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Division_ZeroDividedByMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Division_ZeroDividedByMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Division_ZeroDividedByMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Division_OneDividedByZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = TestUtility.FractionUnitZero;

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
    public void FractionUnit_Division_OneDividedByOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitOne, result);
    }

    [TestMethod]
    public void FractionUnit_Division_OneDividedByMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(187, 24), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_OneDividedByMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitMinusOne, result);
    }

    [TestMethod]
    public void FractionUnit_Division_OneDividedByMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-187, 24), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_MinusOneDividedByZero()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = TestUtility.FractionUnitZero;

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
    public void FractionUnit_Division_MinusOneDividedByOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitMinusOne, result);
    }

    [TestMethod]
    public void FractionUnit_Division_MinusOneDividedByMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-187, 24), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_MinusOneDividedByMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitOne, result);
    }

    [TestMethod]
    public void FractionUnit_Division_MinusOneDividedByMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(187, 24), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_MoreDividedByZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = TestUtility.FractionUnitZero;

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
    public void FractionUnit_Division_MoreDividedByOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_MoreDividedByMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(187, 358), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_MoreDividedByMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_MoreDividedByMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-187, 358), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_MinusMoreDividedByZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = TestUtility.FractionUnitZero;

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
    public void FractionUnit_Division_MinusMoreDividedByOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_MinusMoreDividedByMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-187, 358), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_MinusMoreDividedByMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Division_MinusMoreDividedByMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a / b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(187, 358), []), result);
    }
}