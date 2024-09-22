namespace Retkon.Fractions.Units.Tests.FractionPart;

[TestClass]
public class FractionUnitAddition
{
    [TestMethod]
    public void FractionUnit_Addition_ZeroPlusZero()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Addition_ZeroPlusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitOne, result);
    }

    [TestMethod]
    public void FractionUnit_Addition_ZeroPlusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(b, result);
    }

    [TestMethod]
    public void FractionUnit_Addition_ZeroPlusMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(b, result);
    }

    [TestMethod]
    public void FractionUnit_Addition_ZeroPlusMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitZero;
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(b, result);
    }

    [TestMethod]
    public void FractionUnit_Addition_OnePlusZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitOne, result);
    }

    [TestMethod]
    public void FractionUnit_Addition_OnePlusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(2, 1), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_OnePlusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(211, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_OnePlusMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Addition_OnePlusMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(1, 1), []);
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(163, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MinusOnePlusZero()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitMinusOne, result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MinusOnePlusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(TestUtility.FractionUnitZero, result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MinusOnePlusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-163, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MinusOnePlusMinusOne()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-2, 1), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MinusOnePlusMinusMore()
    {
        // Arrange
        var a = TestUtility.FractionUnitMinusOne;
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-211, 187), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MorePlusZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MorePlusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(191, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MorePlusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(6540, 33473), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MorePlusMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-167, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MorePlusMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(12, 179), []);
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-2052, 33473), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MinusMorePlusZero()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = TestUtility.FractionUnitZero;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-12, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MinusMorePlusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = new FractionUnit(new Fraction(1, 1), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(167, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MinusMorePlusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = new FractionUnit(new Fraction(24, 187), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(2052, 33473), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MinusMorePlusMinusOne()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = TestUtility.FractionUnitMinusOne;

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-191, 179), []), result);
    }

    [TestMethod]
    public void FractionUnit_Addition_MinusMorePlusMinusMore()
    {
        // Arrange
        var a = new FractionUnit(new Fraction(-12, 179), []);
        var b = new FractionUnit(new Fraction(-24, 187), []);

        // Act
        var result = a + b;

        // Assert
        Assert.AreEqual(new FractionUnit(new Fraction(-6540, 33473), []), result);
    }
}